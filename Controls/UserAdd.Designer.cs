namespace WindowsFormsApp1.Controls
{
    partial class UserAdd
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.TextBox();
            this.psd = new System.Windows.Forms.TextBox();
            this.borrownum = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "权限等级";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "借书数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "用户名称";
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(277, 259);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(158, 21);
            this.level.TabIndex = 19;
            // 
            // psd
            // 
            this.psd.Location = new System.Drawing.Point(277, 220);
            this.psd.Name = "psd";
            this.psd.Size = new System.Drawing.Size(158, 21);
            this.psd.TabIndex = 18;
            // 
            // borrownum
            // 
            this.borrownum.Location = new System.Drawing.Point(277, 177);
            this.borrownum.Name = "borrownum";
            this.borrownum.Size = new System.Drawing.Size(158, 21);
            this.borrownum.TabIndex = 17;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(277, 98);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(158, 21);
            this.username.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 41);
            this.button2.TabIndex = 26;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // genderbox
            // 
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "",
            "男",
            "女"});
            this.genderbox.Location = new System.Drawing.Point(277, 139);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(158, 20);
            this.genderbox.TabIndex = 27;
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.level);
            this.Controls.Add(this.psd);
            this.Controls.Add(this.borrownum);
            this.Controls.Add(this.username);
            this.Name = "UserAdd";
            this.Text = "UserAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.TextBox psd;
        private System.Windows.Forms.TextBox borrownum;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox genderbox;
    }
}