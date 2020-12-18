using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1.Forms
{
    public partial class BorrowBook : Form
    {
        public BorrowBook(UserModel user)
        {
            InitializeComponent();
            this.user = user;
        }
        private DBHelper dh = new DBHelper();
        private MySqlConnection conn = null;
        private MySqlDataAdapter da = null;
        private DataSet ds = null;
        private MySqlCommand cmd = null;
        private UserModel user = null;

        private void button3_Click(object sender, EventArgs e)//重置
        {
            this.username.Text = "";
            this.bookname.Text = "";
            this.isborrowbox.Text = "";
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

        private void showdata(string sql)
        {
            try
            {
                conn = dh.Connection;
                da = new MySqlDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds, "borrowtable");
                this.dataGridView1.DataSource = ds.Tables["borrowtable"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh()
        {
            string sql;
            if (user.Level == 1)
            {
                sql = string.Format(@"SELECT bid,username,bookname,btime,srtime,isbor
                                        FROM borrowbook, book, USER
                                        WHERE borrowbook.`uid`= user.`uid` AND borrowbook.`ISBN`= book.`ISBN`");
            }
            else
            {
                sql = string.Format(@"SELECT bid,username,bookname,btime,srtime,isbor
                                        FROM borrowbook, book, USER
                                        WHERE borrowbook.`uid`= user.`uid` AND borrowbook.`ISBN`= book.`ISBN` AND user.`uid`={0}", user.Uid);
            }
            showdata(sql);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)//搜索
        {
            string sql;
            if (user.Level == 1)
            {
                sql = string.Format(@"SELECT bid,username,bookname,btime,srtime,isbor 
                                        FROM borrowbook, book, USER
                                        WHERE borrowbook.`uid`= user.`uid` AND borrowbook.`ISBN`= book.`ISBN`");
            }
            else
            {
                sql = string.Format(@"SELECT bid,username,bookname,btime,srtime,isbor 
                                        FROM borrowbook, book, USER
                                        WHERE borrowbook.`uid`= user.`uid` AND borrowbook.`ISBN`= book.`ISBN` AND user.`uid`={0}", user.Uid);
            }
            if (this.username.Text.Trim() == "" || this.username.Text == null)
            {
            }
            else
            {
                sql += string.Format(" and username like '%{0}%' ", this.username.Text.Trim());
            }
            if (this.bookname.Text.Trim() == "" || this.bookname.Text == null)
            {
            }
            else
            {
                sql+= string.Format(" and bookname like '%{0}%' ", this.bookname.Text.Trim());
            }
            if (this.isborrowbox.Text.Trim() == "" || this.isborrowbox.Text == null)
            {
            }
            else
            {
                sql+= string.Format(" and isborrow='{0}' ", this.isborrowbox.Text.Trim());
            }

            showdata(sql);
        }

        private void returnBook()
        {
            MySqlTransaction trans = null;
            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                int bid = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                string isbor = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[5].Value);

                //先获取uid和isbn
                string sql2 = string.Format("select * from borrowbook where bid={0}", bid);
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                DataSet ds1 = new DataSet();
                MySqlDataAdapter da1 = new MySqlDataAdapter(sql2, conn);
                da1.Fill(ds1, "borrowbooktable");
                int uid = Convert.ToInt32(ds1.Tables["borrowbooktable"].Rows[0].ItemArray[1]);
                string isbn = Convert.ToString(ds1.Tables["borrowbooktable"].Rows[0].ItemArray[2]);

                //添加事务
                trans = conn.BeginTransaction();
                cmd2.Transaction = trans;

                if (isbor == "是")
                {
                    string sql3 = string.Format("update user set borrowNum=borrowNum-1 where uid={0}", uid);
                    MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                    cmd3.ExecuteNonQuery();

                    string sql4 = string.Format("update book set isborrow='否' where isbn='{0}'", isbn);
                    MySqlCommand cmd4 = new MySqlCommand(sql4, conn);
                    cmd4.ExecuteNonQuery();

                    string sql6 = string.Format("update borrowbook set isbor='否' where bid={0}", bid);
                    MySqlCommand cmd6 = new MySqlCommand(sql6, conn);
                    cmd6.ExecuteNonQuery();

                    DateTime date = DateTime.Now.Date;

                    string sql5 = string.Format("insert into returnbook(bid,rtime) values({0},'{1}')", bid, date);
                    MySqlCommand cmd5 = new MySqlCommand(sql5, conn);
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("还书成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trans.Commit();
                }
                
                refresh();
               
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

        private void button1_Click(object sender, EventArgs e)//还书
        {
            if (DialogResult.OK==MessageBox.Show("是否确定还书？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                returnBook();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!canUse())
            {
                return;
            }

        }

        private void delete()
        {
            MySqlTransaction trans = null;
            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                int bid = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                string isborrow = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[5].Value);

                string sql = string.Format("delete from borrowbook where bid={0}", bid);
                cmd = new MySqlCommand(sql, conn);
                //添加事务
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;

                //先获取uid和isbn
                string sql2 = string.Format("select * from borrowbook where bid={0}",bid);
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                DataSet ds1 = new DataSet();
                MySqlDataAdapter da1 = new MySqlDataAdapter(sql2, conn);
                da1.Fill(ds1, "borrowbooktable");
                int uid = Convert.ToInt32(ds1.Tables["borrowbooktable"].Rows[0].ItemArray[1]);
                string isbn = Convert.ToString(ds1.Tables["borrowbooktable"].Rows[0].ItemArray[2]);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("删除成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (isborrow == "是")
                    {
                        string sql3 = string.Format("update user set borrowNum=borrowNum-1 where uid={0}", uid);
                        MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                        cmd3.ExecuteNonQuery();

                        string sql5 = string.Format("update book set isborrow='否' where isbn='{0}'", isbn);
                        MySqlCommand cmd5 = new MySqlCommand(sql5, conn);
                        cmd5.ExecuteNonQuery();

                    }
                    trans.Commit();
                    refresh();
                }
                else
                {
                    MessageBox.Show("删除失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dh.CloseConnection();
            }
        }

        private void button6_Click(object sender, EventArgs e)//删除
        {
            if (!canUse())
            {
                return;
            }
            if (DialogResult.OK == MessageBox.Show("是否确认删除？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                delete();
            }


        }
    }
}
