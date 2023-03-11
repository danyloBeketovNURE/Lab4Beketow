using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabBeketow
{
    public partial class CreateBook : Form
    {
        private Author author = new Author();
        public CreateBook()
        {
            InitializeComponent();
        }
        public CreateBook(Author author)
        {
            this.author = author;
            InitializeComponent();
        }

        private void saveBook_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(textBox2.Text);
                Book newBook = new Book(textBox1.Text, "parapapa", year, author.initials);
                author.AddBook(newBook);
                Dispose();
            }
            catch
            {
                MessageBox.Show("SORRY something do wrong");
            }
        }
    }
}
