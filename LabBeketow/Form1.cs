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
    public partial class Form1 : Form
    {
        Library library = new Library();
        private List<String> pubHouses = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void UpdateFirstGridView(List<Author> authors)
        {
            dataGridAuthors.DataSource = authors;
            //departmentDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //departmentDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void UpdateSecondGridView(List<Book> books)
        {
            dataGridPartBooks.DataSource = books;
            //workerDataGridView.Columns.Remove(workerDataGridView.Columns[2]);
            //workerDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //workerDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //workerDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void UpdateThirdGridView(List<Book> allBooks)
        {
            allBooksGrid.DataSource = allBooks;
            //AllWorkersDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //AllWorkersDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //AllWorkersDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //AllWorkersDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //AllWorkersDataGridView.CurrentCell = null;
        }
        private void UpdateFourthGridView() {
            dataGridView4.DataSource = library.getBUB().ToList();
        }
        private Author GetSelectedAuthor()
        {
            if (dataGridAuthors.SelectedRows.Count == 0)
                return null;
            return (Author)dataGridAuthors.SelectedRows[0].DataBoundItem;
        }
        private Book GetSelectedBook()
        {
            if (dataGridPartBooks.SelectedRows.Count == 0)
                return null;
            return (Book)dataGridPartBooks.SelectedRows[0].DataBoundItem;
        }
        private PUBs GetSelectedPub()
        {
            if (dataGridView4.SelectedRows.Count == 0)
                return null;
            return (PUBs)dataGridView4.SelectedRows[0].DataBoundItem;
        }

        private void AuthorRegister_Click(object sender, EventArgs e)
        {
            Author author = new Author(textBox1.Text);
            library.addAuthor(author);
            UpdateFirstGridView(library.GetAllAuthors().ToList());
        }

        private void DeleteAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                Author curentAuthor = GetSelectedAuthor();
                if (curentAuthor == null)
                    return;

                library.deleteAuthor(curentAuthor);
                UpdateFirstGridView(library.GetAllAuthors().ToList());
                dataGridAuthors.CurrentCell = null;
                dataGridPartBooks.DataSource = null;
                UpdateThirdGridView(library.GetAllBooks().ToList());
            }
            catch (Exception exception)
            {
                MessageBox.Show("SORRY something do wrong");
            }
        }

        private void changeSelected_Click(object sender, EventArgs e)
        {
            try
            {
                Author curentAuthor = GetSelectedAuthor();

                if (curentAuthor == null)
                    return;

                CorrectAuthor correctAuthorForm = new CorrectAuthor(library, curentAuthor);
                correctAuthorForm.ShowDialog();
                UpdateFirstGridView(library.GetAllAuthors().ToList());
                dataGridAuthors.CurrentCell = null;
                dataGridPartBooks.DataSource = null;
                UpdateThirdGridView(library.GetAllBooks().ToList());
            }
            catch (Exception exception)
            {
                MessageBox.Show("SORRY something do wrong");
            }
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            try
            {
                Author curentAuthor = GetSelectedAuthor();
                if (curentAuthor == null)
                    return;

                CreateBook createBookForm = new CreateBook(curentAuthor, library);
                createBookForm.ShowDialog();
                UpdateSecondGridView(curentAuthor.GetBooks().ToList());
                UpdateThirdGridView(library.GetAllBooks().ToList());
            }
            catch (Exception exception)
            {
                MessageBox.Show("SORRY something do wrong");
            }
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                Book curentBook = GetSelectedBook();
                if (curentBook == null)
                    return;

                Author curentAuthor = GetSelectedAuthor();
                if (curentAuthor == null)
                    return;

                library.deleteSelectedBook(curentAuthor, curentBook);
                UpdateSecondGridView(curentAuthor.GetBooks().ToList());
                UpdateThirdGridView(library.GetAllBooks().ToList());
            }
            catch (Exception exception)
            {
                MessageBox.Show("SORRY something do wrong");

            }
        }

        private void changeBook_Click(object sender, EventArgs e)
        {
            try
            {
                Book curentBook = GetSelectedBook();
                if (curentBook == null)
                    return;

                Author curentAuthor = GetSelectedAuthor();
                if (curentAuthor == null)
                    return;
                ChangeBook changeBookForm = new ChangeBook(library, curentBook);
                changeBookForm.ShowDialog();
                UpdateSecondGridView(curentAuthor.GetBooks().ToList());
                UpdateThirdGridView(library.GetAllBooks().ToList());
            }
            catch (Exception exception)
            {
                MessageBox.Show("SORRY something do wrong");
            }
        }

        private void SortBooks_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
                {
                    MessageBox.Show("Please select type of sorting!");
                    return;
                }
                List<Book> books = new List<Book>();

                if (checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
                    books = library.GetAllBooks().OrderBy(x => x.pubHouse).ToList();
                else if (checkBox2.Checked && !checkBox1.Checked && !checkBox3.Checked && !checkBox4.Checked)
                    books = library.GetAllBooks().OrderBy(x => x.authorName).ToList();
                else if (checkBox3.Checked && !checkBox2.Checked && !checkBox1.Checked && !checkBox4.Checked)
                    books = library.GetAllBooks().OrderBy(x => x.bookName).ToList();
                else if (checkBox4.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox1.Checked)
                    books = library.GetAllBooks().OrderBy(x => x.Year).ToList();
                else { MessageBox.Show("SORRY something do wrong"); }
                

                UpdateThirdGridView(books);
            }
            catch (Exception exception)
            {

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            library.Save();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            library.LoadData();
            dataGridAuthors.CurrentCell = null;
            UpdateFirstGridView(library.GetAllAuthors().ToList());
            UpdateFourthGridView();
            UpdateThirdGridView(library.GetAllBooks().ToList());
        }

        private void dataGridAuthors_CurrentCellChanged(object sender, EventArgs e)
        {
            Author author = GetSelectedAuthor();
            if (author == null) return;
            UpdateSecondGridView(author.GetBooks().ToList());
        }

        private void createPUB_Click(object sender, EventArgs e)
        {
            library.addPUB(textBox2.Text);
            UpdateFourthGridView();
        }

        private void deletePUB_Click(object sender, EventArgs e)
        {
            try
            {
                PUBs curentPUB = GetSelectedPub();
                if (curentPUB == null)
                    return;

                library.deletePUB(curentPUB);
                UpdateFourthGridView();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
