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
using WindowsFormsApp1.Controls;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1.Forms
{
    public partial class User : Form
    {
        public User(UserModel user)
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
        private UserAdd userAdd = null;

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

        private void showData(String sql)
        {
            try
            {
                conn = dh.Connection;
                da = new MySqlDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds, "usertable");
                this.dataGridView1.DataSource = ds.Tables["usertable"];
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
                sql = "select * from user";
            }
            else
            {
                sql = string.Format("select * from user where uid={0}", user.Uid);
            }
            
            showData(sql);
        }

        private void cleardata()
        {
            this.txtuid.Text = "";
            this.username.Text = "";
            this.gender.Text = "";
            this.borrownum.Text = "";
            this.psd.Text = "";
            this.level.Text = "";
        }


        private void User_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            refresh();
            cleardata();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private bool check()
        {
            if (this.txtuid.Text.Trim() == "" || this.txtuid.Text == null)
            {
                MessageBox.Show("UID不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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

        private void update()
        {
            int uid = Convert.ToInt32(this.txtuid.Text.Trim());
            string username = Convert.ToString(this.username.Text.Trim());
            string gender = Convert.ToString(this.gender.Text.Trim());
            string borrownum = Convert.ToString(this.borrownum.Text.Trim());
            string psd = Convert.ToString(this.psd.Text.Trim());
            int level = Convert.ToInt32(this.level.Text.Trim());
            MySqlTransaction trans = null;
            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                string sql = string.Format("update user set username='{0}',gender='{1}',borrowNum={2},psd='{3}',level={4} where uid={5} and level!=1",
                    username, gender, borrownum, psd, level, uid);

                cmd = new MySqlCommand(sql, conn);
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;

                if (user.Level == 1)
                {
                }
                else
                {
                    string sql2 = string.Format("select * from user where uid={0} and level={1}", uid, level);
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    int result = Convert.ToInt32(cmd2.ExecuteScalar());
                    if (result > 0)
                    {
                    }
                    else
                    {
                        MessageBox.Show("不可修改权限等级!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trans.Commit();
                    refresh();
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

        private void button1_Click(object sender, EventArgs e)//修改
        {
            if (check())
            {
                if (DialogResult.OK == MessageBox.Show("是否确认修改？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    update();
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtuid.Text = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[0].Value);
            this.username.Text = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[1].Value);
            this.gender.Text = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[2].Value);
            this.borrownum.Text = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[3].Value);
            this.psd.Text = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[4].Value);
            this.level.Text = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[5].Value);

        }

        private void delete()
        {
            MySqlTransaction trans = null;
            try
            {
                conn = dh.Connection;
                dh.OpenConnection();
                string uid = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[0].Value);

                string sql = string.Format("delete from user where uid={0} and level!=1", uid);
                cmd = new MySqlCommand(sql, conn);
                trans = conn.BeginTransaction();
                cmd.Transaction = trans;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("删除成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trans.Commit();
                }
                else
                {
                    MessageBox.Show("删除失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button6_Click(object sender, EventArgs e)//删除
        {
            if (!canUse())
            {
                return;
            }
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                if (DialogResult.OK == MessageBox.Show("是否确认删除？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    delete();
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("请选择某单行数据", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)//添加
        {
            if (!canUse())
            {
                return;
            }
            userAdd = new UserAdd(user);
            userAdd.Visible = true;
        }

        private void clear()
        {
            this.txtusername.Text = "";
            this.genderbox.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from user where 1 ";

            if (this.txtusername.Text.Trim() == "" || this.txtusername.Text == null)
            {
            }
            else
            {
                sql += string.Format(" and username like '%{0}%' ", this.txtusername.Text.Trim());
            }
            if (this.genderbox.Text.Trim() == "" || this.genderbox.Text == null)
            {
            }
            else
            {
                sql += string.Format(" and gender='{0}'", this.genderbox.Text.Trim());
            }

            showData(sql);

        }
    }
}
