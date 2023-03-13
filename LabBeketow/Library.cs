using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json;
using System.Runtime.CompilerServices;

namespace LabBeketow
{
    public class Library
    {
        private const string filePathAuth = "Auth.json";
        private const string filePathPUBs = "PUBs.json";

        private List<Author> authors = new List<Author>();
        //////////////////////////////////////////////////////
        private List<PUBs> pubHouses = new List<PUBs>();//
        //////////////////////////////////////////////////////
        public IEnumerable<Author> GetAllAuthors()
        {
            foreach (var item in authors)
            {
                yield return item;
            }
        }
        public void addPUB(string _name)
        {
            PUBs pub = new PUBs();
            pub.name = _name;
            pubHouses.Add(pub);
        }
        public void deletePUB(PUBs PUB)
        {
            pubHouses.Remove(PUB);
        }
        public IEnumerable<PUBs> getBUB()
        {
            foreach (var item in pubHouses)
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
            using (FileStream stream = new FileStream(filePathAuth, FileMode.OpenOrCreate))
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
            using (FileStream stream = new FileStream(filePathPUBs, FileMode.OpenOrCreate))
            {
                pubHouses.Clear();
                try
                {
                    pubHouses = JsonSerializer.Deserialize<List<PUBs>>(stream);
                }
                catch (Exception e)
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
            using (FileStream stream = new FileStream(filePathAuth, FileMode.Create))
            {
                JsonSerializer.Serialize<List<AuthorDTO>>(stream, authorDTOs);
            }
            using (FileStream stream = new FileStream(filePathPUBs, FileMode.Create))
            {
                JsonSerializer.Serialize<List<PUBs>>(stream, pubHouses);
            }
        }
    }
}
