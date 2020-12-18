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
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1.Controls
{
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();
        }
        private DBHelper dh = new DBHelper();
        private MySqlConnection conn = null;
        private MySqlCommand cmd = null;
        

        private bool check()
        {
            if (this.isbn.Text.Trim() == "" || this.isbn.Text == null)
            {
                MessageBox.Show("ISBN不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.isbn.Focus();
                return false;
            }
            if (this.bookname.Text.Trim() == "" || this.bookname.Text == null)
            {
                MessageBox.Show("图书名称不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.bookname.Focus();
                return false;
            }
            if (this.author.Text.Trim() == "" || this.author.Text == null)
            {
                MessageBox.Show("作者名称不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.author.Focus();
                return false;
            }
            if (this.press.Text.Trim() == "" || this.press.Text == null)
            {
                MessageBox.Show("出版社不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.press.Focus();
                return false;
            }
            if (this.price.Text.Trim() == "" || this.price.Text == null)
            {
                MessageBox.Show("价格不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.price.Focus();
                return false;
            }
            return true;
        }

        private void insert()
        {
            string isbn = this.isbn.Text.Trim();
            string bookname = this.bookname.Text.Trim();
            string author = this.author.Text.Trim();
            string press = this.press.Text.Trim();
            string price = this.price.Text.Trim();

            MySqlTransaction trans = null;
            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                string sql = string.Format("insert into book values('{0}','{1}','{2}','{3}',{4},'{5}')",
                    isbn, bookname, author, press, price,"否");
                cmd = new MySqlCommand(sql, conn);
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("添加成功!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trans.Commit();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("添加失败!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (DialogResult.OK == MessageBox.Show("是否确认添加？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    insert();
                }
               

            }

        }

        private void clearData()
        {
            this.isbn.Text = "";
            this.bookname.Text = "";
            this.author.Text = "";
            this.press.Text = "";
            this.price.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void BookAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
