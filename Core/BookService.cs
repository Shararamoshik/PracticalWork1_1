using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core
{
    public class BookService
    {
        private List<Book> _books = new List<Book>();
        private int _nextId = 1;

        public void CreateBook(string title, string author, int year)
        {
            _books.Add(new Book { Id = _nextId++, Title = title, Author = author, Year = year });
        }

        public bool DeleteBook(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _books.Remove(book);
                return true;
            }
            return false;
        }

        public Book ReadBook(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> GetAllBooks()
        {
            return _books;
        }

        public bool UpdateBook(int id, string title, string author, int year)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book == null) return false;

            book.Title = title;
            book.Author = author;
            book.Year = year;
            return true;
        }

        public Dictionary<string, List<Book>> GroupByAuthor()
        {
            return _books.GroupBy(b => b.Author)
                        .ToDictionary(g => g.Key, g => g.ToList());
        }

        public List<Book> GetBooksByYear(int year)
        {
            return _books.Where(b => b.Year == year).ToList();
        }
    }
}