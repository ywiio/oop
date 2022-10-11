using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Test
    {
        public int Value { get; set; }

        public static Test operator +(Test c1, Test c2)
        {
            return new Test { Value = c1.Value + c2.Value };
        }
    }

    public class Cars
    {
        public string Name { get; set; }

        //public static Cars operator >>(Cars mycars)
        //{
        //
        //}
        //public static Cars operator +(Cars cars, int s2)
        //{
        //    return cars;
        //}

        public class Owner
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Corp { get; set; }
            public string Date { get; set; }
            public int Count { get; set; }

            public Owner(string id, string name, string corp, string Nameofcar)
            {
                Id = id;
                Name = name;
                Corp = corp;
                Nameofcar = "a";
            }

        }

        Date date;

    }


    public class Date
    {
        public static string getdate()
        {
            DateTime curdate = new DateTime();
            curdate = DateTime.Now;
            return curdate.ToString();
        }
    }

    public static class StaticOperation
    {
        public static int Count(this List<Cars> ts)
        {
            return ts.Count;
        }
        public static string findword(this List<Cars> mycars)
        {
            string Biggestword = string.Empty;
            for (int i = 0; i < mycars.Count; i++)
            {
                string[] given = mycars[i].Name.Split(' ');
                for (int j = 0; j < given.Length; j++)
                {
                    if (given[j].Length > Biggestword.Length) Biggestword = given[j];
                }
            }
            return Biggestword;
        }
        public static List<Cars> deletelastitem(this List<Cars> mycars)
        {
            mycars.Remove(mycars.Last());
            return mycars;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> mycars = new List<Cars>();
            mycars.Add(new Cars() { Name = "Skoda Rapid" });
            mycars.Add(new Cars() { Name = "Renault Sandero" });
            mycars.Add(new Cars() { Name = "Peugeout 406" });
            mycars.Add(new Cars() { Name = "Geely Atlas" });

            for (int i = 0; i < mycars.Count; i++)
            {
                Console.WriteLine(mycars[i].Name);
            }
            Console.WriteLine("count: " + mycars.Count);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("biggest vord: " +StaticOperation.findword(mycars));
            Console.ReadKey();

            Console.WriteLine("\ndelete last item: ");
            StaticOperation.deletelastitem(mycars);
            for (int i = 0; i < mycars.Count; i++)
            {
                Console.WriteLine(mycars[i].Name);
            }
            Console.WriteLine("count: " + mycars.Count);
            Console.ReadKey();

            Console.WriteLine();
            Cars.Owner Max = new Cars.Owner("1", "Max", "SCAM inc.", "a");
            Max.Date = Date.getdate();
            Console.WriteLine(Max.Id);
            Console.WriteLine(Max.Name);
            Console.WriteLine(Max.Corp);
            Console.WriteLine(Max.Date);
            //Console.WriteLine(Max.Count);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("count: "+StaticOperation.Count(mycars));
            Console.ReadKey();

            Console.WriteLine();
            int del = 1 >> 0; 
            mycars.RemoveAt(del);
            for (int i = 0; i < mycars.Count; i++)
            {
                Console.WriteLine(mycars[i].Name);
            }
            Console.WriteLine();

            int add = 0 + 0; 
            mycars.Insert(add, new Cars() { Name = "Honda Accord" });
            for (int i = 0; i < mycars.Count; i++)
            {
                Console.WriteLine(mycars[i].Name);
            }

            Console.WriteLine("\n test: ");
            Test int1 = new Test { Value = 42 };
            Test int2 = new Test { Value = 24 };
            Test int3 = int1 + int2;
            Console.WriteLine(int3.Value);
            Console.ReadKey();
        }

    }
}
