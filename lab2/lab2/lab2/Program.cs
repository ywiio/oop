// 6 variant
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Book.Book;

namespace Book
{
    public partial class uwu 
    {
        public void func_1()
        {
            Console.Write("Hello, ");
        }
    }

    public class Book
    {
        private string name;
        public string Name
        {
            set
            {
                if (name == "")
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

        //public Random rnd = new Random();
        
        public struct ID
        {
            private int n;

            public ID(int value)
            {
                n = value;
            }

            public int Value
            {
                get { return n; }
            }

            public override int GetHashCode()
            {
                return n;
            }

            public override string ToString()
            {
                return n.ToString();
            }
        }
        public readonly int id;


        public static int count = 0;
        public const string shop= "OZ";// неявно будет создаваться поле с модификатором readonly
        private string city;
        public string City
        { 
            get
            {
                return "Minsk";
            }
        }

        static Book()
        {
            Console.WriteLine("Hello, start");
        }
       
        public Book() 
        { 
            name = "Неизвестно";
            author = "Неизвестно";
            publishing = "Неизвестно";
            yearOfPublishing = 2000;
            pages = 0;
            price = 0;
            binding = "Твердый";
            id = id.GetHashCode();
            Print();
        }

        private Book(string name)
        {
            this.name = name;
            author = "Неизвестно";
            publishing = "Неизвестно";
            yearOfPublishing = 2000;
            pages = 0;
            price = 0;
            binding = "Твердый";
            id = id.GetHashCode();
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
            this.id = this.GetHashCode() ;
            this.city = City;
                
            count++;
            Print();
        }


        public void Print()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("author: " + author);
            Console.WriteLine("publishing: " + publishing);
            Console.WriteLine("year of publishing: " + yearOfPublishing);
            Console.WriteLine("pages: " + pages);
            Console.WriteLine("price: " + price);
            Console.WriteLine("binding: " + binding);
            Console.WriteLine("id: " + id.GetHashCode());
            //var testpri = new Books("private is work"); //Создаем экземпляр private класса
            //Console.WriteLine(testpri.a);
            Console.WriteLine("how many objects: " + count);
            Console.WriteLine();
        }

        public static void StaticPrint(Book a)
        {
            Console.WriteLine($"object: " +a.ToString());
            Console.WriteLine("name: " + a.name);
            Console.WriteLine("author: " + a.author);
            Console.WriteLine("publishing: " + a.publishing);
            Console.WriteLine("year of publishing: " + a.yearOfPublishing);
            Console.WriteLine("pages: " + a.pages);
            Console.WriteLine("price: " + a.price);
            Console.WriteLine("binding: " + a.binding);
            Console.WriteLine("id: " + a.GetHashCode());
            Console.WriteLine("how many objects: " + count);
            Console.WriteLine();
        }

        public static void Stat(ref int count, out int number) 
        {
            count=0;
            number = 5;
        }

        public static bool Equals(Book a, Book b)
        {
            if (a == b)
            {
                return true;
            }
            if (a == null || b == null)
            {
                return false;
            }
            return a.Equals(b);
        }

       
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
            //Console.WriteLine("Write shop: ");
            //string shop=Console.ReadLine();
            Console.WriteLine("Write city: ");
            string city = Console.ReadLine();
            int id=0; 

            Book Book0 = new Book(name, author, publishing, yearOfPublishing,pages, price, binding,id);
            books[0] = Book0;
            if (name == "") Book0.Name = "";
            if (author == "") Book0.Author = "";
            if (publishing == "") Book0.Publishing = "";
        }
        static void Main(string[] args)
        {

            var Book1 = new Book("Понедельник начинается в субботу", "Аркадий Натанович Стругацкий, Борис Натанович Стругацкий", "АСТ", 2016, 320, 17.40, "Мягкая", 0);
            Book Book2 = new Book("Понедельник начинается в субботу", "Аркадий Натанович Стругацкий, Борис Натанович Стругацкий", "АСТ", 2022, 288, 21.09, "Твердая", 0);
            Book Book3 = new Book("Гарри Поттер и Кубок огня", "Джоан Роулинг", "Махаон", 2019, 704, 41.9, "Твердая", 0);
            
            //вызо закрытого конструктора
            //Book Book4 = new Book("fghjk");

            Book[] books = new Book[4];
            
            books[1] = Book1;
            books[2] = Book2;
            books[3] = Book3;
            Create(books);
            Console.ReadKey();


            Console.WriteLine("Do u want to see books?\n1-yes, 2-no");
            int ans = int.Parse(Console.ReadLine());
            if(ans==1)
            {
                Console.Clear();
                foreach (Book book in books)
                {

                    Book.StaticPrint(book);
                }
            }


            Console.WriteLine("Write author: ");
            string author = Console.ReadLine();
            for (int i = 0; i < books.Length; i++)
            {
                if (author == books[i].Author)
                {
                    Console.WriteLine($"name: {books[i].Name}");
                    Console.WriteLine($"author: {books[i].Author}");
                    Console.WriteLine($"publishing: {books[i].Publishing}");
                    Console.WriteLine($"year of publishing: {books[i].yearOfPublishing}");
                    Console.WriteLine($"pages: {books[i].pages}");
                    Console.WriteLine($"price: {books[i].price}");
                    Console.WriteLine($"type of binding: {books[i].binding}");
                    Console.WriteLine($"city: {books[i].City}");
                    Console.WriteLine();
                }
            }
            Console.ReadKey();


            Console.WriteLine("Write year of publishing: ");
            int yearOfPublishing = int.Parse(Console.ReadLine());
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].yearOfPublishing >= yearOfPublishing)
                {
                    Console.WriteLine($"name: {books[i].Name}");
                    Console.WriteLine($"author: {books[i].Author}");
                    Console.WriteLine($"publishing: {books[i].Publishing}");
                    Console.WriteLine($"year of publishing: {books[i].yearOfPublishing}");
                    Console.WriteLine($"pages: {books[i].pages}");
                    Console.WriteLine($"price: {books[i].price}");
                    Console.WriteLine($"type of binding: {books[i].binding}");
                    Console.WriteLine($"city: {books[i].City}");
                    Console.WriteLine();
                }
            }
            Console.ReadKey();


            uwu nerevar = new uwu();
            nerevar.func_1();
            nerevar.func_2();
            Console.WriteLine();
            Console.ReadKey();

            int number;
            Book.Stat(ref Book.count, out number);
            Console.WriteLine($"ref: { Book.count}\n out: {number}");

            Console.WriteLine("Do u want to compare elements?\n1-yes, 2-no");
            ans = int.Parse(Console.ReadLine());
            if (ans == 1)
            {
                Console.Clear();
                for (int i=1;i<books.Length;i++)
                {
                    bool compare = Book.Equals(books[i-1], books[i]);
                    Console.WriteLine($"book{i}==book{i+1} - {compare}");
                }
            }


            Console.ReadKey();
        }
    }
   
}
