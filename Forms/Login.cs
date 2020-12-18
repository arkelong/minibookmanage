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
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1.Controls;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private DBHelper dh = new DBHelper();
        private MainForm mf = null;
        private MySqlConnection conn = null;
        private UserModel user = null;
        private Register register = null;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.username.Text = "";
            this.password.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.username.Text.Trim() == "" || this.username.Text == null)
            {
                MessageBox.Show("请输入用户名!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.username.Focus();
            }
            if (this.password.Text.Trim() == "" || this.password.Text == null)
            {
                MessageBox.Show("请输入密码!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.password.Focus();
            }

            string username = this.username.Text;
            string password = this.password.Text;

            
            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                string sql1 = string.Format("select * from user where username='{0}' and psd='{1}'", username, password);
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                int result1 = Convert.ToInt32(cmd1.ExecuteScalar());

                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql1,conn);
                da.Fill(ds, "usertable");
                //MessageBox.Show(Convert.ToString(ds.Tables["usertable"].Rows[0].ItemArray[0]));
                int uid = Convert.ToInt32(ds.Tables["usertable"].Rows[0].ItemArray[0]);
                username = Convert.ToString(ds.Tables["usertable"].Rows[0].ItemArray[1]);
                string gender = Convert.ToString(ds.Tables["usertable"].Rows[0].ItemArray[2]);
                int borrowNum = Convert.ToInt32(ds.Tables["usertable"].Rows[0].ItemArray[3]);
                string psd = Convert.ToString(ds.Tables["usertable"].Rows[0].ItemArray[4]);
                int level = Convert.ToInt32(ds.Tables["usertable"].Rows[0].ItemArray[5]);
                user = new UserModel(uid, username, gender, borrowNum, psd, level);


                if (result1 > 0)
                {
                    string sql2 = string.Format("select level from user where username='{0}' and psd='{1}'", username, password);
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    int result2 = Convert.ToInt32(cmd2.ExecuteScalar());
                    mf = new MainForm(user);
                    mf.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("账号或密码错误！请检查后登录", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dh.CloseConnection();
            }
            



        }

       

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            register = new Register();
            register.Visible = true;

        }
    }
}
