using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBeketow
{
    public class Author
    {
        private List<Book> books = new List<Book>();
        public string initials { get; set; }
        public string id { get; set; } = Guid.NewGuid().ToString();
        public Author()
        {

        }
        public Author(string initials)
        {
            this.initials = initials;
        }
        public Author(string id, string initials, List<Book> list) //ctor with params
        {
            this.id = id;
            this.initials = initials;
            foreach (Book book in list) 
            {
                books.Add(book);
            }
        }
        public IEnumerable<Book> GetBooks()
        {
            foreach (var item in books)
            {
                yield return item;
            }
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public bool RemoveBook(Book book)
        {
            return books.Remove(book);
        }
        public AuthorDTO ToDTO()
        {
            return new AuthorDTO()
            {
                initials = this.initials,
                id = this.id,
                books = GetBooks().ToList()
            };
        }
    }
}
