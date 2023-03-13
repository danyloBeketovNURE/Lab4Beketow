using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBeketow
{
    public class Book
    {
        public string bookName { get; set; }
        public PUBs pubHouse { get; set; }
        private int _year;
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 0)
                    _year = 0;
                else
                    _year = value;
            }
        }
        public string authorName { get; set; }
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public Book() { }
        public Book(string bookName,PUBs pubHouse, int year, string authorName)
        {
            this.bookName = bookName;
            this.pubHouse = pubHouse;
            this.Year = year;
            this.authorName = authorName;
        }
    }
}
