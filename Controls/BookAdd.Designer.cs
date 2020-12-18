namespace WindowsFormsApp1.Controls
{
    partial class BookAdd
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
            this.isbn = new System.Windows.Forms.TextBox();
            this.bookname = new System.Windows.Forms.TextBox();
            this.press = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(254, 69);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(213, 21);
            this.isbn.TabIndex = 0;
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(254, 114);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(212, 21);
            this.bookname.TabIndex = 1;
            // 
            // press
            // 
            this.press.Location = new System.Drawing.Point(254, 202);
            this.press.Name = "press";
            this.press.Size = new System.Drawing.Size(213, 21);
            this.press.TabIndex = 2;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(255, 157);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(213, 21);
            this.author.TabIndex = 3;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(254, 243);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(214, 21);
            this.price.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "图书名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "作者名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "出版社";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "价格";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(185, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(439, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 58);
            this.button2.TabIndex = 11;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "BookAdd";
            this.Text = "BookAdd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookAdd_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox press;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}