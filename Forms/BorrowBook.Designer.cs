namespace WindowsFormsApp1.Forms
{
    partial class BorrowBook
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
            this.button1 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.bookname = new System.Windows.Forms.TextBox();
            this.isborrowbox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.BID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.图书名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借书时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.应还时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否借出 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BID,
            this.用户名称,
            this.图书名称,
            this.借书时间,
            this.应还时间,
            this.是否借出});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(46, 161);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(710, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "还书";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(46, 111);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(141, 21);
            this.username.TabIndex = 2;
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(244, 111);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(150, 21);
            this.bookname.TabIndex = 3;
            // 
            // isborrowbox
            // 
            this.isborrowbox.FormattingEnabled = true;
            this.isborrowbox.Items.AddRange(new object[] {
            "",
            "是",
            "否"});
            this.isborrowbox.Location = new System.Drawing.Point(444, 112);
            this.isborrowbox.Name = "isborrowbox";
            this.isborrowbox.Size = new System.Drawing.Size(70, 20);
            this.isborrowbox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "搜索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(670, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "重置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "是否借出";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "图书名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "用户名称";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 42);
            this.button4.TabIndex = 10;
            this.button4.Text = "刷新";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(244, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 42);
            this.button6.TabIndex = 12;
            this.button6.Text = "删除";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // BID
            // 
            this.BID.DataPropertyName = "bid";
            this.BID.HeaderText = "BID";
            this.BID.Name = "BID";
            this.BID.ReadOnly = true;
            // 
            // 用户名称
            // 
            this.用户名称.DataPropertyName = "username";
            this.用户名称.HeaderText = "用户名称";
            this.用户名称.Name = "用户名称";
            this.用户名称.ReadOnly = true;
            // 
            // 图书名称
            // 
            this.图书名称.DataPropertyName = "bookname";
            this.图书名称.HeaderText = "图书名称";
            this.图书名称.Name = "图书名称";
            this.图书名称.ReadOnly = true;
            // 
            // 借书时间
            // 
            this.借书时间.DataPropertyName = "btime";
            this.借书时间.HeaderText = "借书时间";
            this.借书时间.Name = "借书时间";
            this.借书时间.ReadOnly = true;
            // 
            // 应还时间
            // 
            this.应还时间.DataPropertyName = "srtime";
            this.应还时间.HeaderText = "应还时间";
            this.应还时间.Name = "应还时间";
            this.应还时间.ReadOnly = true;
            // 
            // 是否借出
            // 
            this.是否借出.DataPropertyName = "isbor";
            this.是否借出.HeaderText = "是否借出";
            this.是否借出.Name = "是否借出";
            this.是否借出.ReadOnly = true;
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.isborrowbox);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BorrowBook";
            this.Text = "BorrowBook";
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.ComboBox isborrowbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn BID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 图书名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借书时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 应还时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否借出;
    }
}