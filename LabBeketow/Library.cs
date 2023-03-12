using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json;

namespace LabBeketow
{
    public class Library
    {
        private const string filePath = "SavedLibrary.json";

        private List<Author> authors = new List<Author>();
        //////////////////////////////////////////////////////
        private List<String> pubHouses = new List<String>();//
        //////////////////////////////////////////////////////
        public IEnumerable<Author> GetAllAuthors()
        {
            foreach (var item in authors)
            {
                yield return item;
            }
        }
         public List<Book> GetAllBooks()                                  
        {                                                                     
            List<Book> books = new List<Book>();                        
            foreach (Author item in authors)                            
            {
                List<Book> subBooks = new List<Book>();                  
                subBooks = item.GetBooks().ToList();                       
                foreach (Book book in subBooks)                          
                {                                                             
                    books.Add(book);                                      
                }
            }                                                                 
            return books;                                                   
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

        public void LoadData()
        {
            authors.Clear();
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                try
                {
                    List<AuthorDTO> loadedAuthors = JsonSerializer.Deserialize<List<AuthorDTO>>(stream);
                    foreach (AuthorDTO authorDTO in loadedAuthors)
                        authors.Add(authorDTO.ToAuthor());
                }
                catch
                {
                    MessageBox.Show("Incorrect file");
                }
            }
        }
        public void Save()
        {
            List<AuthorDTO> authorDTOs = new List<AuthorDTO>();
            foreach (Author item in authors)
            {
                AuthorDTO DTO = item.ToDTO();
                authorDTOs.Add(DTO);
            }
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                JsonSerializer.Serialize<List<AuthorDTO>>(stream, authorDTOs);
            }
        }
    }
}
