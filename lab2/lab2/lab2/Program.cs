// 6 variant
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Book
{
    public class Book
    {
        private string name;
        public string Name
        {
            set
            {
                if(name=="")
                {
                    Console.WriteLine("Book name is not set");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

        private string author;
        public string Author
        {
            set
            {
                if (author == "")
                {
                    Console.WriteLine("Author is not set");
                }
                else
                {
                    author = value;
                }
            }
            get
            {
                return author;
            }
        }

        private string publishing;
        public string Publishing
        {
            set
            {
                if (publishing == "")
                {
                    Console.WriteLine("Publishing is not set");
                }
                else
                {
                    publishing = value;
                }
            }
            get
            {
                return publishing;
            }
        }

        public int yearOfPublishing { get; set; }
        public int pages { get; set; }
        public double price { get; set; }
        public string binding { get; set; }
        public readonly int id;
        public Random random=new Random();
        static Book()
        {
            Console.WriteLine("Hello, start");
        }
        // закрытый конструктор???????
        public Book() 
        { 
            name = "Неизвестно";
            author = "Неизвестно";
            publishing = "Неизвестно";
            yearOfPublishing = 2000;
            pages = 0;
            price = 0;
            binding = "Твердый";
            id = 0;
            Print();
        }
        public Book(string name)
        {
            this.name = name;
            author = "Неизвестно";
            publishing = "Неизвестно";
            yearOfPublishing = 2000;
            pages = 0;
            price = 0;
            binding = "Твердый";
            id = 0;
            Print();
        }
        public Book(string name, string author, string publishing, int yearOfPublishing, int pages, double price, string binding, int id)
        {
            this.name = name;
            this.author = author;
            this.publishing = publishing;
            this.yearOfPublishing = yearOfPublishing;
            this.pages = pages;
            this.price = price;
            this.binding = binding; 
            this.id = random.Next();
            Print();
        }
        public void Print() => Console.WriteLine($"\nName: {name}  Author: {author}\nPublishing: {publishing}\nid: {id}  Year of publishing: {yearOfPublishing}\nPages: {pages}\nPrice: {price} BYN\nType of binding: {binding}\n");
    }

    

    class Program
    {
        static void Create(Book[] books)
        {
            Console.WriteLine("Write book name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Write book author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Write book publishing: ");
            string publishing = Console.ReadLine();
            Console.WriteLine("Write year of publishing: ");
            int yearOfPublishing = int.Parse(Console.ReadLine());
            Console.WriteLine("How many pages: ");
            int pages = int.Parse(Console.ReadLine());
            Console.WriteLine("Write price: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Write type of binding: ");
            string binding = Console.ReadLine();
            int id = 0; 

            //зачем
            Book Book0 = new Book(name, author, publishing, yearOfPublishing,pages, price, binding, id);
            if (name == "") Book0.Name = "";
            if (author == "") Book0.Author = "";
            if (publishing == "") Book0.Publishing = "";
        }
        static void Main(string[] args)
        {
            Book Book1 = new Book("Понедельник начинается в субботу", "Аркадий Натанович Стругацкий, Борис Натанович Стругацкий", "АСТ", 2016, 320, 17.40, "Мягкая", 0);
            Book Book2 = new Book("Понедельник начинается в субботу", "Аркадий Натанович Стругацкий, Борис Натанович Стругацкий", "АСТ", 2022, 288, 21.09, "Твердая", 0);
            Book Book3 = new Book("Гарри Поттер и Кубок огня", "Джоан Роулинг", "Махаон", 2019, 704, 41.9, "Твердая", 0);

            Book[] books = new Book[4];
            
            books[1] = Book1;
            books[2] = Book2;
            Create(books);
            Console.ReadKey();

            Console.WriteLine("Write author: ");
            string author=Console.ReadLine();
            for (int i=0;i<books.Length;i++)
            {
                if (author==books[i].Author)
                {
                    Console.WriteLine($"name: {books[i].Name}");
                    Console.WriteLine($"author: {books[i].Author}");
                    Console.WriteLine($"publishing: {books[i].Publishing}");
                    Console.WriteLine($"year of publishing: {books[i].yearOfPublishing}");
                    Console.WriteLine($"pages: {books[i].pages}");
                    Console.WriteLine($"price: {books[i].price}");
                    Console.WriteLine($"type of binding: {books[i].binding}");
                    Console.WriteLine();
                }
            }
            Console.ReadKey();

            Console.WriteLine("Write year of publishing: ");
            int yearOfPublishing = int.Parse(Console.ReadLine());
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].yearOfPublishing == yearOfPublishing)
                {
                    Console.WriteLine($"name: {books[i].Name}");
                    Console.WriteLine($"author: {books[i].Author}");
                    Console.WriteLine($"publishing: {books[i].Publishing}");
                    Console.WriteLine($"year of publishing: {books[i].yearOfPublishing}");
                    Console.WriteLine($"pages: {books[i].pages}");
                    Console.WriteLine($"price: {books[i].price}");
                    Console.WriteLine($"type of binding: {books[i].binding}");
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
   
}
