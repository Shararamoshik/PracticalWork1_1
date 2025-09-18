using Core;
using System;

namespace ConsoleApp
{
    class Program
    {
        static BookService bookService = new BookService();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Создать книгу");
                Console.WriteLine("2. Удалить книгу");
                Console.WriteLine("3. Показать книгу по ID");
                Console.WriteLine("4. Показать все книги");
                Console.WriteLine("5. Обновить книгу");
                Console.WriteLine("6. Сгруппировать по авторам");
                Console.WriteLine("7. Найти книги по году");
                Console.WriteLine("0. Выйти");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": CreateBook(); break;
                    case "2": DeleteBook(); break;
                    case "3": ReadBook(); break;
                    case "4": ShowAllBooks(); break;
                    case "5": UpdateBook(); break;
                    case "6": GroupByAuthor(); break;
                    case "7": GetBooksByYear(); break;
                    case "0": return;
                }

                Console.WriteLine();
            }
        }

        static void CreateBook()
        {
            Console.Write("Название: ");
            var title = Console.ReadLine();
            Console.Write("Автор: ");
            var author = Console.ReadLine();
            Console.Write("Год: ");
            var year = int.Parse(Console.ReadLine());

            bookService.CreateBook(title, author, year);
            Console.WriteLine("Книга создана!");
        }

        static void DeleteBook()
        {
            Console.Write("ID книги для удаления: ");
            var id = int.Parse(Console.ReadLine());

            if (bookService.DeleteBook(id))
                Console.WriteLine("Книга удалена!");
            else
                Console.WriteLine("Книга не найдена!");
        }

        static void ReadBook()
        {
            Console.Write("ID книги: ");
            var id = int.Parse(Console.ReadLine());
            var book = bookService.ReadBook(id);
            if (book != null)
                Console.WriteLine($"Найдена: {book.Title} - {book.Author} ({book.Year})");
            else
                Console.WriteLine("Книга не найдена");
        }

        static void ShowAllBooks()
        {
            var books = bookService.GetAllBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}: {book.Title} - {book.Author} ({book.Year})");
            }
        }

        static void UpdateBook()
        {
            Console.Write("ID книги для обновления: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Новое название: ");
            var title = Console.ReadLine();
            Console.Write("Новый автор: ");
            var author = Console.ReadLine();
            Console.Write("Новый год: ");
            var year = int.Parse(Console.ReadLine());

            if (bookService.UpdateBook(id, title, author, year))
                Console.WriteLine("Книга обновлена!");
            else
                Console.WriteLine("Книга не найдена!");
        }

        static void GroupByAuthor()
        {
            var groups = bookService.GroupByAuthor();
            foreach (var group in groups)
            {
                Console.WriteLine($"Автор: {group.Key}");
                foreach (var book in group.Value)
                {
                    Console.WriteLine($"  {book.Title} ({book.Year})");
                }
            }
        }

        static void GetBooksByYear()
        {
            Console.Write("Год: ");
            var year = int.Parse(Console.ReadLine());
            var books = bookService.GetBooksByYear(year);
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} - {book.Author}");
            }
        }
    }
}