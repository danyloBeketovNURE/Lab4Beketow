using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabBeketow
{
    public class Library
    {
        private List<Author> authors = new List<Author>();
        public IEnumerable<Author> GetAllAuthors()
        {
            foreach (var item in authors)
            {
                yield return item;
            }
        }
        public void addAuthor(Author registredAuthor)
        {
            if (authors.Any(x => x.id.Equals(registredAuthor.id)))
            {
                MessageBox.Show("Author with the same id is already exists");
                return;
            }
            else if (authors.Any(x => x.initials.Equals(registredAuthor.initials)))
            {
                MessageBox.Show("Author with the same name is already exists");
                return;
            }
            authors.Add(registredAuthor);
            return;
        }
        public void deleteAuthor(Author authorToDelete)
        {
            if (authorToDelete == null)
            {
                MessageBox.Show($"Please select author to delete");
                return;
            }
            authors.Remove(authorToDelete);
            return;
        }
        public bool correctInitialsCheck(String initials)
        {
            if (authors.Any(x => x.initials == initials))
            {
                MessageBox.Show("Author with the same id is already exists");
                return false;
            }
            return true;
        }
        public void deleteSelectedBook(Author author, Book book)
        {
            if (author == null)
            {
                MessageBox.Show($"Please select book to delete");
                return;
            }
            author.RemoveBook(book);
            return;
        }

    }
}
