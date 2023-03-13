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
            this.allBooksGrid = new System.Windows.Forms.DataGridView();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SortBooks = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.createPUB = new System.Windows.Forms.Button();
            this.deletePUB = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksGrid)).BeginInit();
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
            this.dataGridAuthors.ReadOnly = true;
            this.dataGridAuthors.RowHeadersWidth = 51;
            this.dataGridAuthors.RowTemplate.Height = 24;
            this.dataGridAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAuthors.Size = new System.Drawing.Size(306, 434);
            this.dataGridAuthors.TabIndex = 0;
            this.dataGridAuthors.CurrentCellChanged += new System.EventHandler(this.dataGridAuthors_CurrentCellChanged);
            // 
            // dataGridPartBooks
            // 
            this.dataGridPartBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPartBooks.Location = new System.Drawing.Point(521, 77);
            this.dataGridPartBooks.Name = "dataGridPartBooks";
            this.dataGridPartBooks.ReadOnly = true;
            this.dataGridPartBooks.RowHeadersWidth = 51;
            this.dataGridPartBooks.RowTemplate.Height = 24;
            this.dataGridPartBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPartBooks.Size = new System.Drawing.Size(306, 434);
            this.dataGridPartBooks.TabIndex = 1;
            // 
            // allBooksGrid
            // 
            this.allBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allBooksGrid.Location = new System.Drawing.Point(846, 77);
            this.allBooksGrid.Name = "allBooksGrid";
            this.allBooksGrid.ReadOnly = true;
            this.allBooksGrid.RowHeadersWidth = 51;
            this.allBooksGrid.RowTemplate.Height = 24;
            this.allBooksGrid.Size = new System.Drawing.Size(320, 305);
            this.allBooksGrid.TabIndex = 2;
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
            this.dataGridView4.Location = new System.Drawing.Point(1187, 77);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(306, 305);
            this.dataGridView4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1184, 58);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1057, 403);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "By publishing";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1057, 429);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 20);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "By author";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1057, 455);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(82, 20);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "By name";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(1057, 481);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 20);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "By year";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // SortBooks
            // 
            this.SortBooks.Location = new System.Drawing.Point(846, 399);
            this.SortBooks.Name = "SortBooks";
            this.SortBooks.Size = new System.Drawing.Size(205, 112);
            this.SortBooks.TabIndex = 14;
            this.SortBooks.Text = "Sort";
            this.SortBooks.UseVisualStyleBackColor = true;
            this.SortBooks.Click += new System.EventHandler(this.SortBooks_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(18, 520);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(809, 137);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save all";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(846, 517);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(647, 140);
            this.LoadButton.TabIndex = 16;
            this.LoadButton.Text = "Load from disc";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // createPUB
            // 
            this.createPUB.Location = new System.Drawing.Point(1187, 431);
            this.createPUB.Name = "createPUB";
            this.createPUB.Size = new System.Drawing.Size(151, 80);
            this.createPUB.TabIndex = 17;
            this.createPUB.Text = "Create house";
            this.createPUB.UseVisualStyleBackColor = true;
            this.createPUB.Click += new System.EventHandler(this.createPUB_Click);
            // 
            // deletePUB
            // 
            this.deletePUB.Location = new System.Drawing.Point(1344, 431);
            this.deletePUB.Name = "deletePUB";
            this.deletePUB.Size = new System.Drawing.Size(149, 80);
            this.deletePUB.TabIndex = 18;
            this.deletePUB.Text = "Delete house";
            this.deletePUB.UseVisualStyleBackColor = true;
            this.deletePUB.Click += new System.EventHandler(this.deletePUB_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1187, 403);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 22);
            this.textBox2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 669);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.deletePUB);
            this.Controls.Add(this.createPUB);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SortBooks);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
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
            this.Controls.Add(this.allBooksGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAuthors;
        private System.Windows.Forms.DataGridView dataGridPartBooks;
        private System.Windows.Forms.DataGridView allBooksGrid;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button SortBooks;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button createPUB;
        private System.Windows.Forms.Button deletePUB;
        private System.Windows.Forms.TextBox textBox2;
    }
}

