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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabBeketow
{
    public partial class CorrectAuthor : Form
    {
        private Library library = new Library();
        private Author author = new Author();   
        public CorrectAuthor()
        {
            InitializeComponent();
        }
        public CorrectAuthor(Library library, Author author)
        {
            this.library = library;
            this.author = author;   
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (library.correctInitialsCheck(textBox1.Text))
            {
                author.initials = textBox1.Text;
                foreach (var item in author.GetBooks())
                    item.authorName = author.initials;
            }
            Dispose();
        }
        private void CorrectAuthor_Load(object sender, EventArgs e)
        {
            textBox1.Text = author.initials;
        }
    }
}
