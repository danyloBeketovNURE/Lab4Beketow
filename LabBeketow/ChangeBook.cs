using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBeketow
{
    public partial class ChangeBook : Form
    {
        Library library = new Library();
        Book book = new Book();
        public ChangeBook()
        {
            InitializeComponent();
        }
        public ChangeBook(Library library, Book book)
        {
            this.library = library;
            this.book = book;
            InitializeComponent();
        }

        private void saveBook_Click(object sender, EventArgs e)
        {
            try
            {
                book.Year = int.Parse(textBox2.Text);
                book.bookName = textBox1.Text;
                Dispose();
            }
            catch
            {
                MessageBox.Show("SORRY something do wrong");
            }
        }

        private void ChangeBook_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = book.bookName;
            textBox2.Text = book.Year.ToString();
        }
    }
}
