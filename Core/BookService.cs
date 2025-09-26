using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Core
{
    public class BookService
    {
        private static string _dataFile = "C:\\Users\\Ivan\\Pictures\\books.json";
        private List<Book> _books;
        private int _nextId = 1;

        public BookService()
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            if (File.Exists(_dataFile))
            {
                try
                {
                    string json = File.ReadAllText(_dataFile);
                    _books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
                    _nextId = _books.Count > 0 ? _books.Max(b => b.Id) + 1 : 1;
                }
                catch
                {
                    _books = new List<Book>();
                }
            }
            else
            {
                _books = new List<Book>();
            }
        }

        private void SaveBooks()
        {
            try
            {
                string json = JsonSerializer.Serialize(_books, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_dataFile, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка сохранения: {ex.Message}");
            }
        }

        public void CreateBook(string title, string author, int year)
        {
            lock (_books)
            {
                _books.Add(new Book { Id = _nextId++, Title = title, Author = author, Year = year });
                SaveBooks();
            }
        }

        public bool DeleteBook(int id)
        {
            lock (_books)
            {
                var book = _books.FirstOrDefault(b => b.Id == id);
                if (book != null && _books.Remove(book))
                {
                    SaveBooks();
                    return true;
                }
                return false;
            }
        }

        public Book ReadBook(int id)
        {
            LoadBooks(); // Всегда загружаем свежие данные
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> GetAllBooks()
        {
            LoadBooks(); // Всегда загружаем свежие данные
            return new List<Book>(_books);
        }

        public bool UpdateBook(int id, string title, string author, int year)
        {
            lock (_books)
            {
                var book = _books.FirstOrDefault(b => b.Id == id);
                if (book == null) return false;

                book.Title = title;
                book.Author = author;
                book.Year = year;
                SaveBooks();
                return true;
            }
        }

        public Dictionary<string, List<Book>> GroupByAuthor()
        {
            LoadBooks();
            return _books.GroupBy(b => b.Author)
                        .ToDictionary(g => g.Key, g => g.ToList());
        }

        public List<Book> GetBooksByYear(int year)
        {
            LoadBooks();
            return _books.Where(b => b.Year == year).ToList();
        }
    }
}