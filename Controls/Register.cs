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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private DBHelper dh = new DBHelper();

        private void button1_Click(object sender, EventArgs e)
        {
            this.username.Text = "";
            this.psd.Text = "";
            this.rpsd.Text = "";
            this.genderbox.Text = "";
        }

        private bool check() {
            if (this.username.Text.Trim() == "" || this.username.Text == null)
            {
                MessageBox.Show("用户名不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.username.Focus();
                return false;
            }
            if (this.psd.Text.Trim() == "" || this.psd.Text == null)
            {
                MessageBox.Show("密码不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.psd.Focus();
                return false;
            }
            if (this.rpsd.Text.Trim() == "" || this.rpsd.Text == null)
            {
                MessageBox.Show("确认密码不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.rpsd.Focus();
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check())
            {
                MySqlTransaction trans = null;
                string username = this.username.Text.Trim();
                string psd = this.psd.Text.Trim();
                string rpsd = this.rpsd.Text.Trim();

                if (psd != rpsd)
                {
                    MessageBox.Show("密码和确认密码不一致", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    MySqlConnection conn = dh.Connection;
                    dh.OpenConnection();
                    string sql1 = string.Format("select uid from user where username='{0}' and psd='{1}'", username,psd);
                    MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                    trans = conn.BeginTransaction();
                    cmd1.Transaction = trans;

                    if (Convert.ToInt32(cmd1.ExecuteScalar()) > 0)
                    {

                        MessageBox.Show("用户已存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string sql2 = string.Format("insert into user(username,gender,borrowNum,psd,level) values('{0}','{1}',{2},'{3}',{4})",
                            username, this.genderbox.Text.Trim(), 0, psd, 2);
                        MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("注册成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            trans.Commit();
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("注册失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
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


        }
    }
}
