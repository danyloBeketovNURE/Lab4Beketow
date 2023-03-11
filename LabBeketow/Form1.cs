﻿using System;
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
        //private void UpdateAllWorkerDataSource(List<Worker> AllWorkers)
        //{
        //    AllWorkersDataGridView.DataSource = AllWorkers;
        //    //AllWorkersDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        //    //AllWorkersDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        //    //AllWorkersDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        //    //AllWorkersDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        //    //AllWorkersDataGridView.CurrentCell = null;
        //}
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
                //UpdateAllWorkerDataSource(company.GetAllWorkers().ToList());
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
                //UpdateAllWorkerDataSource(company.GetAllWorkers().ToList());
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

                CreateBook createBookForm = new CreateBook(curentAuthor);
                createBookForm.ShowDialog();
                UpdateSecondGridView(curentAuthor.GetBooks().ToList());
                //UpdateAllWorkerDataSource(company.GetAllWorkers().ToList());
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
                //UpdateAllWorkerDataSource(company.GetAllWorkers().ToList());
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
                //UpdateAllWorkerDataSource(company.GetAllWorkers().ToList());
            }
            catch (Exception exception)
            {
                MessageBox.Show("SORRY something do wrong");
            }
        }
    }
}