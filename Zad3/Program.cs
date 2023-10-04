using System;
using System.Collections.Generic;

namespace Zad3
{
    // Класс Author представляет автора книги.
    class Author
    {
        public string Name { get; set; } // Имя автора
        public int BirthYear { get; set; } // Год рождения автора

        public Author(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
    }

    // Класс Book представляет информацию о книге и ее авторе.
    class Book
    {
        public string Title { get; set; } // Название книги
        public int Year { get; set; } // Год выпуска книги
        public Author Author { get; set; } // Автор книги

        public Book(string title, int year, Author author)
        {
            Title = title;
            Year = year;
            Author = author;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Автор: {Author.Name}"); // Вывод имени автора
            Console.WriteLine($"Год рождения автора: {Author.BirthYear}"); // Вывод года рождения автора
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем несколько объектов Author
            Author author1 = new Author("Иван Иванов", 1980);
            Author author2 = new Author("Петр Петров", 1990);

            // Создаем несколько объектов Book, связанных с авторами
            Book book1 = new Book("Зимний лес", 2000, author1);
            Book book2 = new Book("Теплый вечер", 2010, author1);
            Book book3 = new Book("Холодная зима", 2020, author2);

            // Выводим информацию о книгах
            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();

            Console.ReadLine();
        }
    }
}
