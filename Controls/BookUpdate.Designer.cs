namespace WindowsFormsApp1.Controls
{
    partial class BookUpdate
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.press = new System.Windows.Forms.TextBox();
            this.bookname = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.isborrow = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "价格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "出版社";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "作者名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "图书名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "ISBN";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(284, 236);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(214, 21);
            this.price.TabIndex = 14;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(285, 150);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(213, 21);
            this.author.TabIndex = 13;
            // 
            // press
            // 
            this.press.Location = new System.Drawing.Point(284, 195);
            this.press.Name = "press";
            this.press.Size = new System.Drawing.Size(213, 21);
            this.press.TabIndex = 12;
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(284, 107);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(212, 21);
            this.bookname.TabIndex = 11;
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(284, 62);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(213, 21);
            this.isbn.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // isborrow
            // 
            this.isborrow.FormattingEnabled = true;
            this.isborrow.Items.AddRange(new object[] {
            "",
            "是",
            "否"});
            this.isborrow.Location = new System.Drawing.Point(371, 281);
            this.isborrow.Name = "isborrow";
            this.isborrow.Size = new System.Drawing.Size(127, 20);
            this.isborrow.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "是否借出";
            // 
            // BookUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isborrow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.author);
            this.Controls.Add(this.press);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.isbn);
            this.Name = "BookUpdate";
            this.Text = "BookUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox press;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox isborrow;
        private System.Windows.Forms.Label label6;
    }
}