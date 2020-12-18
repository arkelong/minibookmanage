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
    public partial class ReturnBook : Form
    {
        public ReturnBook(UserModel user)
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

        private void showData(string sql)
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
                sql = string.Format(@"SELECT rid,username,bookname,btime,srtime,rtime
                                    FROM returnbook,borrowbook,book,USER
                                    WHERE borrowbook.`bid`=returnbook.`bid` 
                                    AND borrowbook.`uid`=user.`uid` 
                                    AND borrowbook.`ISBN`=book.`ISBN`");
            }
            else
            {
                sql = string.Format(@"SELECT rid,username,bookname,btime,srtime,rtime
                                    FROM returnbook,borrowbook,book,USER
                                    WHERE borrowbook.`bid`=returnbook.`bid` 
                                    AND borrowbook.`uid`=user.`uid` 
                                    AND borrowbook.`ISBN`=book.`ISBN` AND user.`uid`={0}", user.Uid);
            }
            showData(sql);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            this.username.Text = "";
            this.bookname.Text = "";
            this.btimepicker.Text = "";
            this.rtimepicker.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            if (user.Level == 1)
            {
                sql = string.Format(@"SELECT rid,username,bookname,btime,srtime,rtime
                                    FROM returnbook,borrowbook,book,USER
                                    WHERE borrowbook.`bid`=returnbook.`bid` 
                                    AND borrowbook.`uid`=user.`uid` 
                                    AND borrowbook.`ISBN`=book.`ISBN`");
            }
            else
            {
                sql = string.Format(@"SELECT rid,username,bookname,btime,srtime,rtime
                                    FROM returnbook,borrowbook,book,USER
                                    WHERE borrowbook.`bid`=returnbook.`bid` 
                                    AND borrowbook.`uid`=user.`uid` 
                                    AND borrowbook.`ISBN`=book.`ISBN` AND user.`uid`={0}", user.Uid);
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
                sql += string.Format(" and bookname like '%{0}%' ", this.bookname.Text.Trim());
            }

            showData(sql);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql;
            if (user.Level == 1)
            {
                sql = string.Format(@"SELECT rid,username,bookname,btime,srtime,rtime
                                    FROM returnbook,borrowbook,book,USER
                                    WHERE borrowbook.`bid`=returnbook.`bid` 
                                    AND borrowbook.`uid`=user.`uid` 
                                    AND borrowbook.`ISBN`=book.`ISBN`");
            }
            else
            {
                sql = string.Format(@"SELECT rid,username,bookname,btime,srtime,rtime
                                    FROM returnbook,borrowbook,book,USER
                                    WHERE borrowbook.`bid`=returnbook.`bid` 
                                    AND borrowbook.`uid`=user.`uid` 
                                    AND borrowbook.`ISBN`=book.`ISBN` AND user.`uid`={0}", user.Uid);
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
                sql += string.Format(" and bookname like '%{0}%' ", this.bookname.Text.Trim());
            }
            sql += string.Format(" and btime='{0}'", this.btimepicker.Value);
            sql += string.Format(" and rtime='{0}'", this.rtimepicker.Value);

            showData(sql);

        }

        private void delete()
        {
            //事务
            MySqlTransaction trans = null;
            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                int rid = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                string sql = string.Format("delete from returnbook where rid={0}", rid);
                cmd = new MySqlCommand(sql, conn);

                trans = conn.BeginTransaction();
                cmd.Transaction = trans;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("删除成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trans.Commit();
                    refresh();
                }
                else
                {
                    MessageBox.Show("删除失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                if (DialogResult.OK==MessageBox.Show("是否确定删除？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    delete();
                }
            }
            else
            {
                MessageBox.Show("请选择某一行数据", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
