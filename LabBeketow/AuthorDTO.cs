using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBeketow
{
    public class AuthorDTO
    {
        public string id { get; set; }
        public string initials { get; set; }
        public List<Book> books { get; set; }
        public AuthorDTO()
        {
            books = new List<Book>();
        }
        public Author ToAuthor()
        {
            return new Author(id, initials, books);
        }
    }
}
