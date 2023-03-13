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
        private Library libr = new Library();
        public CreateBook()
        {
            InitializeComponent();
        }
        public CreateBook(Author author, Library libr)
        {
            this.author = author;
            this.libr = libr;
            InitializeComponent();
        }

        private void saveBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                    throw new Exception();

                int year = int.Parse(textBox2.Text);
                Book newBook = new Book(textBox1.Text, new PUBs(comboBox1.SelectedItem.ToString()), year, author.initials);
                author.AddBook(newBook);
                Dispose();
            }
            catch
            {
                MessageBox.Show("SORRY something do wrong");
            }
        }

        private void CreateBook_Load(object sender, EventArgs e)
        {
            List<PUBs> pubs = libr.getBUB().ToList();
            foreach (var item in pubs)
            {
                comboBox1.Items.Add(item.name);
            }
        }
    }
}
