using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controls;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1(UserModel user)
        {
            InitializeComponent();
            this.user = user;
        }
        private UserModel user = null;
        private DBHelper dh = new DBHelper();
        private MySqlConnection conn = null;
        private MySqlCommand cmd = null;
        private MySqlDataAdapter da = null;
        private DataSet ds = null;
        private BookAdd bookAdd = null;
        private BookUpdate bookUpdate = null;

        public void showData(string sql)
        {
            try
            {
                conn = dh.Connection;
                da = new MySqlDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds, "booktable");
                this.dataGridView1.DataSource = ds.Tables["booktable"];
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearText()
        {
            this.bookname.Text = "";
            this.author.Text = "";
            this.price.Text = "";
        }

        private bool canUse()
        {
            if (user.Level != 1)
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void delete()
        {
            MySqlTransaction trans = null;
            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                string isbn = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                string sql = string.Format("delete from book where isbn='{0}'", isbn);
                cmd = new MySqlCommand(sql, conn);
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("删除成功!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trans.Commit();
                    refresh();
                }
                else
                {
                    MessageBox.Show("删除失败!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dh.CloseConnection();
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!canUse())
            {
                return;
            }
            bookAdd = new BookAdd();
            bookAdd.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!canUse())
            {
                return;
            }

            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                if (DialogResult.OK == MessageBox.Show("确认删除此条数据吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    delete();
                }
            }
            else
            {
                MessageBox.Show("请选择某单行数据", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!canUse())
            {
                return;
            }
            string isbn = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[0].Value);
            string bookname = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[1].Value);
            string author = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[2].Value);
            string press = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[3].Value);
            string price = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[4].Value);
            string isborrow = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[5].Value);

            bookUpdate = new BookUpdate(isbn,bookname,author,press,price,isborrow);
            bookUpdate.Visible = true;

        }


        private void refresh()
        {
            string sql = "select * from book";
            showData(sql);

            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                string sql2 = "select count(*) from book";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                int result = Convert.ToInt32(cmd2.ExecuteScalar());
                this.total.Text = result.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dh.CloseConnection();
            }
            

        }
        private void button6_Click(object sender, EventArgs e)
        {
            refresh();
            clearText();
        }

        private void button4_Click(object sender, EventArgs e)//搜索
        {
            string sql = "select * from book where 1 ";

            if (this.bookname.Text.Trim() == "" || this.bookname.Text == null)
            {
            }
            else
            {
                sql += string.Format(" and bookname like '%{0}%' ", this.bookname.Text.Trim());
            }

            if (this.author.Text.Trim() == "" || this.author.Text == null)
            {
            }
            else
            {
                sql += string.Format(" and author like '%{0}%' ", this.author.Text.Trim());
            }

            if (this.price.Text.Trim() == "" || this.price.Text == null)
            {
            }
            else
            {
                sql += string.Format(" and price = {0}", this.price.Text.Trim());
            }
            showData(sql);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)//借书
        {
            if (Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[5].Value) == "是")
            {
                MessageBox.Show("本书已经被借出", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int uid = user.Uid;
            string isbn = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[0].Value);
            string btime = Convert.ToString(DateTime.Now.Date);
            string srtime = Convert.ToString(DateTime.Now.Date.AddDays(15));
            string isborrow = "是";
            MySqlTransaction trans = null;
            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                string sql1 = string.Format("INSERT INTO borrowbook(uid,ISBN,btime,srtime,isbor) VALUES({0},'{1}','{2}','{3}','{4}')",
                    uid, isbn, btime, srtime,isborrow);
                cmd = new MySqlCommand(sql1, conn);

                trans = conn.BeginTransaction();
                cmd.Transaction = trans;

                
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("借出成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string sql2 = string.Format("update user set borrowNum=borrowNum+1 where uid={0}", uid);
                    MySqlCommand cmd2 = new MySqlCommand(sql2,conn);
                    cmd2.ExecuteNonQuery();

                    string sql3 = string.Format("update book set isborrow='{0}' where isbn='{1}'",isborrow, isbn);
                    MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                    cmd3.ExecuteNonQuery();

                    trans.Commit();
                    refresh();
                }
                else
                {
                    MessageBox.Show("插入失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }catch(Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dh.CloseConnection();
            }

        }
    }
}
