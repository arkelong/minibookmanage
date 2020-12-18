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

namespace WindowsFormsApp1.Controls
{
    public partial class UserAdd : Form
    {
        public UserAdd(UserModel user)
        {
            InitializeComponent();
            this.user = user;
        }
        private UserModel user=null;
        private DBHelper dh = new DBHelper();
        private MySqlConnection conn = null;
        private MySqlCommand cmd = null;

        private void clear()
        {
            this.username.Text = "";
            this.genderbox.Text = "";
            this.borrownum.Text = "";
            this.psd.Text = "";
            this.level.Text = "";
        }
        private bool check()
        {
            if (this.username.Text.Trim() == "" || this.username.Text == null)
            {
                MessageBox.Show("用户名称不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.borrownum.Text.Trim() == "" || this.borrownum.Text == null)
            {
                MessageBox.Show("借书量不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.psd.Text.Trim() == "" || this.psd.Text == null)
            {
                MessageBox.Show("密码不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.level.Text.Trim() == "" || this.level.Text == null)
            {
                MessageBox.Show("权限等级不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)//清空
        {
            clear();
        }

        private void insert()
        {
            string username = this.username.Text.Trim();
            string gender = this.genderbox.Text.Trim();
            string borrownum = this.borrownum.Text.Trim();
            string psd = this.psd.Text.Trim();
            string level = this.level.Text.Trim();
            MySqlTransaction trans = null;
            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                string sql = string.Format("insert into user(username,gender,borrowNum,psd,level) values('{0}','{1}',{2},'{3}',{4})",
                    username, gender, borrownum, psd, level);
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

        private void button2_Click(object sender, EventArgs e)//添加
        {
            if (check())
            {
                if (DialogResult.OK == MessageBox.Show("是否确认添加？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    insert();
                }
            }

        }
    }
}
