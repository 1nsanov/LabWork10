using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        private static Book[] Books = new Book[3];
        static void Main(string[] args)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Books[i] = SetBook();
                Console.Clear();
            }

            OutputBooks();
            OutputBooksByFindAuthor();

            Console.ReadLine();
        }

        private static void OutputBooksByFindAuthor()
        {
            Console.WriteLine("Введите имя автора.");
            var inputAuthor = Console.ReadLine();
            if (TryFindBookByAuthor(inputAuthor))
            {
                for (int i = 0; i < Books.Length; i++)
                {
                    if (Books[i].Author == inputAuthor)
                    {
                        Console.WriteLine(Books[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Книг данного автора нет в наличии");
            }
        }

        private static void OutputBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }

        private static Book SetBook()
        {
            Console.WriteLine("Введите имя Автора.");
            var author = InputValidNull();

            Console.WriteLine("Введите имя Книги.");
            var name = InputValidNull();
            //var name = GenerateText();

            Console.WriteLine("Введите имя Издательства.");
            var publisher = InputValidNull();
            //var publisher = GenerateText();

            Console.WriteLine("Введите год написания книги.");
            var year = InputValidInt();
           // var year = GenerateNumber(1600, 2000);

            Console.WriteLine("Введите кол-во страниц в книге.");
            var countPage = InputValidInt();
            //var countPage = GenerateNumber(300, 900);
            return new Book(author, name, year, publisher, countPage);
        }

        private static bool TryFindBookByAuthor(string inputAuthor)
        {
            var result = Books.FirstOrDefault(b => b.Author == inputAuthor);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string InputValidNull()
        {
            string text;
            while (true)
            {
                text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Данная строка не может быть пустой. Повторите попытку.");
                }
                else
                {
                    return text;
                }
            }
        }

        private static int InputValidInt()
        {
            string number;
            while (true)
            {
                number = Console.ReadLine();
                if (int.TryParse(number, out int num))
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Не верный формат. Повторите попытку.");
                }
            }
        }

        private static string GenerateText()
        {
            return Guid.NewGuid().ToString();
        }
        private static int GenerateNumber(int min, int max)
        {
            var rnd = new Random();
            return rnd.Next(min, max);
        }

    }
}
