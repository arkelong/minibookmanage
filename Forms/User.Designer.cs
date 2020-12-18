namespace WindowsFormsApp1.Forms
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借书数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.权限等级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.borrownum = new System.Windows.Forms.TextBox();
            this.psd = new System.Windows.Forms.TextBox();
            this.level = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.用户名称,
            this.性别,
            this.借书数量,
            this.密码,
            this.权限等级});
            this.dataGridView1.Location = new System.Drawing.Point(22, 199);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(505, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // UID
            // 
            this.UID.DataPropertyName = "uid";
            this.UID.HeaderText = "UID";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            // 
            // 用户名称
            // 
            this.用户名称.DataPropertyName = "username";
            this.用户名称.HeaderText = "用户名称";
            this.用户名称.Name = "用户名称";
            this.用户名称.ReadOnly = true;
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "gender";
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            // 
            // 借书数量
            // 
            this.借书数量.DataPropertyName = "borrowNum";
            this.借书数量.HeaderText = "借书数量";
            this.借书数量.Name = "借书数量";
            this.借书数量.ReadOnly = true;
            // 
            // 密码
            // 
            this.密码.DataPropertyName = "psd";
            this.密码.HeaderText = "密码";
            this.密码.Name = "密码";
            this.密码.ReadOnly = true;
            // 
            // 权限等级
            // 
            this.权限等级.DataPropertyName = "level";
            this.权限等级.HeaderText = "权限等级";
            this.权限等级.Name = "权限等级";
            this.权限等级.ReadOnly = true;
            // 
            // txtuid
            // 
            this.txtuid.Location = new System.Drawing.Point(91, 31);
            this.txtuid.Name = "txtuid";
            this.txtuid.ReadOnly = true;
            this.txtuid.Size = new System.Drawing.Size(103, 21);
            this.txtuid.TabIndex = 1;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(91, 62);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(103, 21);
            this.username.TabIndex = 2;
            // 
            // borrownum
            // 
            this.borrownum.Location = new System.Drawing.Point(91, 141);
            this.borrownum.Name = "borrownum";
            this.borrownum.Size = new System.Drawing.Size(103, 21);
            this.borrownum.TabIndex = 4;
            // 
            // psd
            // 
            this.psd.Location = new System.Drawing.Point(91, 184);
            this.psd.Name = "psd";
            this.psd.Size = new System.Drawing.Size(103, 21);
            this.psd.TabIndex = 5;
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(91, 223);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(103, 21);
            this.level.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(25, 142);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(121, 21);
            this.txtusername.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(328, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "搜索";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(440, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 38);
            this.button4.TabIndex = 11;
            this.button4.Text = "清空";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.level);
            this.panel1.Controls.Add(this.psd);
            this.panel1.Controls.Add(this.borrownum);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.txtuid);
            this.panel1.Location = new System.Drawing.Point(574, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 406);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "权限等级";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "借书数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "用户名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "UID";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(181, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 37);
            this.button5.TabIndex = 13;
            this.button5.Text = "添加用户";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "用户名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "性别";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(328, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 37);
            this.button6.TabIndex = 16;
            this.button6.Text = "删除用户";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 37);
            this.button7.TabIndex = 17;
            this.button7.Text = "刷新";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // genderbox
            // 
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "",
            "男",
            "女"});
            this.genderbox.Location = new System.Drawing.Point(180, 143);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(122, 20);
            this.genderbox.TabIndex = 18;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "",
            "男",
            "女"});
            this.gender.Location = new System.Drawing.Point(92, 103);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(101, 20);
            this.gender.TabIndex = 15;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "User";
            this.Text = "用户信息";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox borrownum;
        private System.Windows.Forms.TextBox psd;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借书数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 权限等级;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.ComboBox gender;
    }
}