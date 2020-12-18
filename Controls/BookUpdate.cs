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
    public partial class BookUpdate : Form
    {
        public BookUpdate(string isbn,string bookname,string author,string press,string price,string isborrow)
        {
            InitializeComponent();
            isbnt = this.isbn.Text = isbn;
            booknamet = this.bookname.Text = bookname;
            authort = this.author.Text = author;
            presst = this.press.Text = press;
            pricet = this.price.Text = price;
            isborrowt = this.isborrow.Text = isborrow;
        }
        private string isbnt;
        private string booknamet;
        private string authort;
        private string presst;
        private string pricet;
        private string isborrowt;
        private DBHelper dh = new DBHelper();
        private MySqlConnection conn = null;
        private MySqlCommand cmd = null;

        private void reback()
        {
            this.isbn.Text = isbnt;
            this.bookname.Text = booknamet;
            this.author.Text = authort;
            this.press.Text = presst;
            this.price.Text = pricet;
            this.isborrow.Text = isborrowt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reback();
        }

        private void update()
        {
            MySqlTransaction trans = null;
            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                string isbn = this.isbn.Text.Trim();
                string bookname = this.bookname.Text.Trim();
                string author = this.author.Text.Trim();
                string press = this.press.Text.Trim();
                string price = this.price.Text.Trim();
                string isborrow = this.isborrow.Text.Trim();

                string sql = string.Format("update book set ISBN='{0}',bookname='{1}',author='{2}',press='{3}',price={4},isborrow='{5}'  where ISBN={6}",
                    isbn, bookname, author, press, price,isborrow,isbnt);

                cmd = new MySqlCommand(sql, conn);
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trans.Commit();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (DialogResult.OK == MessageBox.Show("是否确定修改？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                update();
            }

        }
    }
}
