using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab_1
{
    class Program
    {
        static void ExOne()
        {
            int a = -6;
            uint age = 19;
            bool t = true;
            byte b = 255;
            sbyte sb = -23; /*-127|127*/
            long l = -89000345;
            ulong ul = 89000345;
            string name = "Zlata";
            char c = 'c';
            short sh = -9;
            ushort ush = 9;
            float f = 2 / 3;
            float g = 2.3f;
            double d = 3.5;
            object o = new object();

            Console.WriteLine(a);
            Console.WriteLine($"Имя: {name}, возраст: {age}");
            Console.WriteLine("bool: {2}, byte: {0}, sbyte: {1}", t, b, sb);
            Console.Write(l);
            Console.Write(ul);
            Console.Write("\nchar: {3}, ushort {0}, double {2}, short {1}\n", ush, sh, d, c);
            Console.WriteLine($"object: {o}, float: {f}");

            long num1 =a;
            float num2 = sh;
            decimal num3 = b;
            int num4 = sb;
            double num5 = f;

            int num6 = (int)d;
            decimal num7 = (decimal)f;
            short num8 = (short)g;
            long num9 = (long)d;
            ulong num10 = (ulong)age;
            Console.WriteLine($"{age}\n{num10}");

            num5 = Convert.ToDouble(a);
            num4 = Convert.ToInt32(f);
            name = Convert.ToString(d);
            d = Convert.ToDouble(t);
            b = Convert.ToByte(num10);

            d = num9;
            long k = (long)d;
            a = b;
            byte b1 = (byte)a;

            var v1 = 15.3;
            //v1 = "fghjk";
            dynamic v2 = 15.4;
            v2 = "fghjk";
            var isName = true;
            var n = "Zlata";
            Console.WriteLine(isName.GetType());
            Console.WriteLine(isName);
            Console.WriteLine(n.GetType());
            Console.WriteLine(v1.GetType());

            int? x1 = null;
            int? x2 = 23;
            int? x3 = null;
            Console.WriteLine(x1 == x2);
            if (x2.HasValue) // x2=23 x1=null
            {
                x1 = x2; // x1=23
            }
            Console.WriteLine(x1);
            int y = x3 ?? 1;    //  y=1
            Console.WriteLine(y);
            int y2 = x2 ?? 1;    // y=23
            Console.WriteLine(y2);

            var cl = new { number = 1, company = "Apple" };
            Console.WriteLine(cl.number + ". " + cl.company);
            var company = cl.company;
            Console.WriteLine(company.GetType());
        }
        static void ExTwo()
        {
            Console.WriteLine("Компания \"НИИЧАВО\"");
            Console.WriteLine('a');
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "nooooc";
            string str4 = str1 + " " + str2; // конкатенация
            string str5 = String.Concat(str4, "вапрол");
            Console.WriteLine(str5);
            int result = String.Compare(str1, str3);
            if (result < 0)
            {
                Console.WriteLine("Строка str1 перед str2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка str1 после str2");
            }
            else
            {
                Console.WriteLine("str1 и str2 идентичны");
            }
            char c = 'o';
            int indexOfChar = str3.IndexOf(c);
            Console.WriteLine(indexOfChar);
            string text = "я уточка я в луже и лапками бяк";
            //int *arr = new int[];
            string[] words = text.Split(new char[] {'я'});
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            string add = "бяк";
            text = text.Insert(1, add); //ябяк уточка я в луже и лапками бяк
            Console.WriteLine(text);
            text = text.Remove(1, 3);//я уточка я в луже и лапками бяк
            Console.WriteLine(text);
            string removeLastWord=text.Substring(0,text.Length-3); //я уточка я в луже и лапками бяк
            Console.WriteLine(removeLastWord);
            int x = 8;
            int y = 7;
            string interpol = $"{x} + {y} = {x + y}";
            Console.WriteLine(interpol);
            string str6 = null;
            Console.WriteLine("String 1 {0}.", Test(str1));
            Console.WriteLine("String 2 {0}.", Test(str6));
            String Test(string s)
            {
                if (String.IsNullOrEmpty(s))
                    return "is null or empty";
                else
                    return String.Format("(\"{0}\") is full", s);
            }
            StringBuilder sb=new StringBuilder("sdfjk bekf");
            Console.WriteLine($"string builder");
            Console.WriteLine(sb);
            Console.WriteLine($"length: {sb.Length}, capacity:{sb.Capacity}");
            sb.Append(add);
            Console.WriteLine(sb);
            sb.Insert(5, " :) ");
            Console.WriteLine(sb);
            sb.Replace("bekf", "-_-");
            Console.WriteLine(sb);
            sb.Remove(0,5);
            Console.WriteLine(sb);
            string sbText=sb.ToString();
            Console.WriteLine(sbText);
        }
        static void ExThree()
        {
            //3.a
            Console.Write("how many lines: ");
            int numberOfLines = int.Parse(Console.ReadLine());

            Console.Write("how many elements: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            int[,] arrayA = new int[numberOfLines, numberOfElements];

            Console.WriteLine("array:");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfElements; j++)
                {
                    Console.Write($"write {i}.{j} element: ");
                    arrayA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfElements; j++)
                {
                    Console.Write(arrayA[i, j] + " ");
                }
                Console.WriteLine();
            }

            //3.b
            Console.Write("how many elements:\t");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCount];
            Console.WriteLine("array:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"write {i} element:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.Write("write number of replace element\t");
            int numberOfReplase = int.Parse(Console.ReadLine());
            Console.Write("write value\t");
            int valueOfReplase = int.Parse(Console.ReadLine());
            Console.WriteLine("new array:");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i == numberOfReplase)
                {
                    myArray[i] = valueOfReplase;
                }
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();

            //3.c
            int[][] arrayC = new int[3][];
            arrayC[0] = new int[2]; // G K
            arrayC[1] = new int[3]; // G K G
            arrayC[2] = new int[4]; // G K G T
            for (int i = 0; i < arrayC.Length; i++)
            {
                for (int j = 0; j < arrayC[i].Length; j++)
                {
                    Console.Write($"element[{i}][{j}] = ");
                    arrayC[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < arrayC.Length; i++)
            {
                for (int j = 0; j < arrayC[i].Length; j++)
                {
                    Console.Write(arrayC[i][j] + " ");
                }
                Console.WriteLine();
            }
            //3.d
            var arrayD = new int[5];
            var str7 = "";
        }
        static void ExFour()
        {
            (int, string, char, string, ulong) tuple = (1, "zlata", 'a', "ywiio", 23456);
            Console.WriteLine(tuple.Item1 + " " + tuple.Item3 + " " + tuple.Item4);
            var (myName, myNick) = (tuple.Item2, tuple.Item4);
            var tupleOfNumbers_1 = (23, 67);
            var tupleOfNumbers_2 = (23, 67);
            (int numberOne, int numberTwo) = tupleOfNumbers_1;
            Console.WriteLine(tupleOfNumbers_1 == tupleOfNumbers_2);
            var Person = ("John", "Smith");
            var (First, _) = Person;
            Debug.Print(First);
        }
        static void ExFive()
        {
            int[] myArray = { 34, 26, 1 };
            string str1 = "daghjk";
            char firstLetter=str1.First();
            //firstLetter.Substring(1, str1);
            
            (int, int, int, char) GetValues()
            {
                int max = myArray[0];
                int min = myArray[0];
                int count = 0;
                int Max()
                {
                    for (int i = 1; i < myArray.Length; i++)
                    {
                        if (myArray[i] > max)
                        {
                            max = myArray[i];
                        }
                    }
                    return max;
                }
                int Min()
                {
                    for (int i = 1; i < myArray.Length; i++)
                    {
                        if (myArray[i] < min)
                        {
                            min = myArray[i];
                        }
                    }
                    return min;
                }
                int Sum()
                {
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        count += myArray[i];
                    }
                    return count;
                }
                max = Max();
                min = Min();
                count = Sum();
                var result = (max, min, count, firstLetter);
                return result;
            }
            var tuple = GetValues();
            Console.WriteLine($"max: {tuple.Item1}, min: {tuple.Item2}, count: {tuple.Item3}, first letter: {tuple.Item4}");
           
            void TupleChecked()
            {
                try
                {
                    int a = 33;
                    int b = 600;
                    byte c = checked((byte)(a + b));
                    Console.WriteLine(c);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return;
            }
            void TupleUnchecked()
            {
                try
                {
                    int a = 33;
                    int b = 600;
                    byte c = unchecked((byte)(a + b));
                    Console.WriteLine(c);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return;
            }
            Console.WriteLine("ch|unch");
            TupleChecked();
            TupleUnchecked();
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Choose number of exercise:\n");
                Console.WriteLine("1/2/3/4/5/6");
                //int choise = int.Parse(Console.ReadLine());
                string choise = Console.ReadLine();
                if (choise == "1")
                {
                    ExOne();
                }
                if (choise == "2")
                {
                    ExTwo();
                }
                if (choise == "3")
                {
                    ExThree();
                }
                if (choise == "4")
                {
                    ExFour();
                }
                if (choise == "5")
                {
                    ExFive();
                }
                if (choise == "0")
                {
                    break;
                }
            } while (true);
        }
    }
}
