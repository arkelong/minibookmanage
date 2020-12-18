namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.书名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版社 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否借出 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bookname = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.书名,
            this.作者,
            this.出版社,
            this.价格,
            this.是否借出});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(46, 151);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(723, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // 书名
            // 
            this.书名.DataPropertyName = "bookname";
            this.书名.HeaderText = "书名";
            this.书名.Name = "书名";
            this.书名.ReadOnly = true;
            // 
            // 作者
            // 
            this.作者.DataPropertyName = "author";
            this.作者.HeaderText = "作者";
            this.作者.Name = "作者";
            this.作者.ReadOnly = true;
            // 
            // 出版社
            // 
            this.出版社.DataPropertyName = "press";
            this.出版社.HeaderText = "出版社";
            this.出版社.Name = "出版社";
            this.出版社.ReadOnly = true;
            // 
            // 价格
            // 
            this.价格.DataPropertyName = "price";
            this.价格.HeaderText = "价格";
            this.价格.Name = "价格";
            this.价格.ReadOnly = true;
            // 
            // 是否借出
            // 
            this.是否借出.DataPropertyName = "isborrow";
            this.是否借出.HeaderText = "是否借出";
            this.是否借出.Name = "是否借出";
            this.是否借出.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "增加图书";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除图书";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(637, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "修改图书";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(46, 107);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(134, 21);
            this.bookname.TabIndex = 4;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(238, 108);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(138, 21);
            this.author.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(446, 105);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(130, 21);
            this.price.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(608, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "搜索";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "书名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(237, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "作者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(447, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "价格";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(694, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 29);
            this.button5.TabIndex = 11;
            this.button5.Text = "重置";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(45, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 35);
            this.button6.TabIndex = 12;
            this.button6.Text = "刷新";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(639, 393);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 45);
            this.button7.TabIndex = 13;
            this.button7.Text = "借书";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(159, 413);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(99, 21);
            this.total.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "数据条数为";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "条";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.total);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.author);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "图书信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn 书名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版社;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否借出;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

