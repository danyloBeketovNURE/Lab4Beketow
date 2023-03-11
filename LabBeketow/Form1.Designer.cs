namespace LabBeketow
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridAuthors = new System.Windows.Forms.DataGridView();
            this.dataGridPartBooks = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthorRegister = new System.Windows.Forms.Button();
            this.DeleteAuthor = new System.Windows.Forms.Button();
            this.changeSelected = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeBook = new System.Windows.Forms.Button();
            this.deleteBook = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAuthors
            // 
            this.dataGridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthors.Location = new System.Drawing.Point(110, 77);
            this.dataGridAuthors.Name = "dataGridAuthors";
            this.dataGridAuthors.RowHeadersWidth = 51;
            this.dataGridAuthors.RowTemplate.Height = 24;
            this.dataGridAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAuthors.Size = new System.Drawing.Size(306, 434);
            this.dataGridAuthors.TabIndex = 0;
            // 
            // dataGridPartBooks
            // 
            this.dataGridPartBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPartBooks.Location = new System.Drawing.Point(521, 77);
            this.dataGridPartBooks.Name = "dataGridPartBooks";
            this.dataGridPartBooks.RowHeadersWidth = 51;
            this.dataGridPartBooks.RowTemplate.Height = 24;
            this.dataGridPartBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPartBooks.Size = new System.Drawing.Size(306, 434);
            this.dataGridPartBooks.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(846, 77);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(306, 434);
            this.dataGridView3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "authors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "author`s books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(843, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "all books";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 22);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(1170, 77);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(306, 434);
            this.dataGridView4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1167, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "publishing houses";
            // 
            // AuthorRegister
            // 
            this.AuthorRegister.Location = new System.Drawing.Point(5, 7);
            this.AuthorRegister.Name = "AuthorRegister";
            this.AuthorRegister.Size = new System.Drawing.Size(89, 52);
            this.AuthorRegister.TabIndex = 0;
            this.AuthorRegister.Text = "Register author";
            this.AuthorRegister.UseVisualStyleBackColor = true;
            this.AuthorRegister.Click += new System.EventHandler(this.AuthorRegister_Click);
            // 
            // DeleteAuthor
            // 
            this.DeleteAuthor.Location = new System.Drawing.Point(6, 65);
            this.DeleteAuthor.Name = "DeleteAuthor";
            this.DeleteAuthor.Size = new System.Drawing.Size(88, 51);
            this.DeleteAuthor.TabIndex = 1;
            this.DeleteAuthor.Text = "Delete selected";
            this.DeleteAuthor.UseVisualStyleBackColor = true;
            this.DeleteAuthor.Click += new System.EventHandler(this.DeleteAuthor_Click);
            // 
            // changeSelected
            // 
            this.changeSelected.Location = new System.Drawing.Point(5, 122);
            this.changeSelected.Name = "changeSelected";
            this.changeSelected.Size = new System.Drawing.Size(89, 57);
            this.changeSelected.TabIndex = 2;
            this.changeSelected.Text = "Change selected";
            this.changeSelected.UseVisualStyleBackColor = true;
            this.changeSelected.Click += new System.EventHandler(this.changeSelected_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changeSelected);
            this.panel1.Controls.Add(this.DeleteAuthor);
            this.panel1.Controls.Add(this.AuthorRegister);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 240);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.changeBook);
            this.panel2.Controls.Add(this.deleteBook);
            this.panel2.Controls.Add(this.addBook);
            this.panel2.Location = new System.Drawing.Point(422, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 240);
            this.panel2.TabIndex = 9;
            // 
            // changeBook
            // 
            this.changeBook.Location = new System.Drawing.Point(6, 122);
            this.changeBook.Name = "changeBook";
            this.changeBook.Size = new System.Drawing.Size(89, 52);
            this.changeBook.TabIndex = 3;
            this.changeBook.Text = "Change selected";
            this.changeBook.UseVisualStyleBackColor = true;
            this.changeBook.Click += new System.EventHandler(this.changeBook_Click);
            // 
            // deleteBook
            // 
            this.deleteBook.Location = new System.Drawing.Point(6, 65);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(89, 52);
            this.deleteBook.TabIndex = 2;
            this.deleteBook.Text = "Delete selected";
            this.deleteBook.UseVisualStyleBackColor = true;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(6, 7);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(89, 52);
            this.addBook.TabIndex = 1;
            this.addBook.Text = "Add book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 551);
            this.Controls.Add(this.dataGridPartBooks);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridAuthors);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAuthors;
        private System.Windows.Forms.DataGridView dataGridPartBooks;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AuthorRegister;
        private System.Windows.Forms.Button DeleteAuthor;
        private System.Windows.Forms.Button changeSelected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button changeBook;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.Button addBook;
    }
}

