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

namespace WindowsFormsApp1.Forms
{
    public partial class MainForm : Form
    {
        public MainForm(UserModel userm)
        {
            InitializeComponent();
            this.userm = userm;
        }
        private Form1 book = null;
        private User user = null;
        private UserModel userm = null;
        private BorrowBook borrowbook = null;
        private ReturnBook returnBook = null;

        private bool canUse()
        {
            if (userm.Level != 1)
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button1_Click(object sender, EventArgs e)//图书信息
        {
            book = new Form1(userm);
            book.Visible = true;

        }

        

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)//借书信息
        {
            borrowbook = new BorrowBook(userm);
            borrowbook.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)//用户信息
        {
            user = new User(userm);
            user.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)//还书信息
        {
            returnBook = new ReturnBook(userm);
            returnBook.Visible = true;
        }
    }
}
