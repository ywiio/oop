using System;
using System.Text;
//при завершении пункта не выводит варианты выбора след
//изменить меню выбора в мейн
namespace Lab_1
{
    class Program
    {
        static void ExOne()
        {
            
        }
        static void ExTwo()
        {
            Console.WriteLine("Компания \"НИИЧАВО\"");
            Console.WriteLine('a');
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "nooooc";
            string str4 = str1 + " " + str2; //конкатенация
            string str5 = String.Concat(str4, "???");
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
            string[] words = text.Split(new char[] { ' ' });
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            string add = "бяк";
            text = text.Insert(indexOfChar, add);
            Console.WriteLine(text);
            text = text.Remove(indexOfChar, 3);
            Console.WriteLine(text);
            //выделение подстроки, интерполирование
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
            // что еще с null string
            // string builder
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
            arrayC[0] = new int[2];
            arrayC[1] = new int[3];
            arrayC[2] = new int[4];
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

            //(_) ??
        }
        static void ExFive()
        {
            int[] myArray = { 34, 26, 1 };
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            string str1 = "dfghjk";
            string firstLetter = "";
            //firstLetter = firstLetter.Substring(1, str1);
            var tuple = GetValues();
            (int, int, int, string) GetValues()
            {
                int max = 0;
                int min = 0;
                int count = 0;
                int Max()
                {
                    for (int i = 0; i < myArray.Length; i++)
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
                    for (int i = 0; i < myArray.Length; i++)
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
                Max();
                Min();
                Sum();
                var result = (max, min, count, firstLetter);
                return result;
            }
            //Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Choose exercise:\n");
                Console.WriteLine(
                    "1-1a\n" + "2-1b\n" + "3-1c\n" + "4-1d\n" + "5-1e\n" +
                    "6-2ab\n" + "7-2c\n" + "8-2d\n" + "9-3a\n" + "10-3b\n" +
                    "11-3c\n" + "12-3d\n" + "13-4a\n" + "14-5\n" + "15-6a\n" + "16-6b\n" + "0-exit\n"
                    );
                int choise = int.Parse(Console.ReadLine());
                if (choise == 1)
                {
                    ExOne();
                    break;
                }
                if (choise == 2)
                {
                    ExTwo();
                    break;
                }
                if (choise == 3)
                {
                    ExThree();
                    break;
                }
                if (choise == 4)
                {
                    ExFour();
                    break;
                }
                if (choise == 1)
                {
                    ExFive();
                    break;
                }
                else if (choise == 0)
                {
                    break;
                }
                else Console.WriteLine("incorrect answer");
            }while (true);
        }
    }
}




//do
//{
//    Console.WriteLine("Choose <T>:\n");
//    Console.WriteLine(
//        "1-int\n" + "2-uint\n" + "3-bool\n" + "4-byte\n" + "5-sbyte\n" +
//        "6-long\n" + "7-ulong\n" + "8-string\n" + "9-char\n" + "10-short\n" +
//        "11-ushort\n" + "12-float\n" + "13-double\n" + "14-decimal\n" + "0-exit\n"
//        );
//    int choise = int.Parse(Console.ReadLine());
//    if (choise == 1)
//    {
//        Console.WriteLine("write value: ");
//        int aint = int.Parse(Console.ReadLine());
//        Console.WriteLine($"int={aint}");
//        Console.ReadLine();
//    }
//    else if (choise == 2)
//    {
//        Console.WriteLine("write value: ");
//        uint auint = uint.Parse(Console.ReadLine());
//        Console.WriteLine($"uint={auint}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 3)
//    {
//        Console.WriteLine("write value: ");
//        bool abool = bool.Parse(Console.ReadLine());
//        Console.WriteLine($"bool={abool}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 4)
//    {
//        Console.WriteLine("write value: ");
//        byte abyte = byte.Parse(Console.ReadLine());
//        Console.WriteLine($"byte={abyte}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 5)
//    {
//        Console.WriteLine("write value: ");
//        sbyte asbyte = sbyte.Parse(Console.ReadLine());
//        Console.WriteLine($"sbyte={asbyte}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 6)
//    {
//        Console.WriteLine("write value: ");
//        long along = long.Parse(Console.ReadLine());
//        Console.WriteLine($"long={along}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 7)
//    {
//        Console.WriteLine("write value: ");
//        ulong aulong = ulong.Parse(Console.ReadLine());
//        Console.WriteLine($"ulong={aulong}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 8)
//    {
//        Console.WriteLine("write string: ");
//        string astring = Console.ReadLine();
//        Console.WriteLine($"string={astring}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 9)
//    {
//        Console.WriteLine("write value: ");
//        char achar = char.Parse(Console.ReadLine());
//        Console.WriteLine($"char={achar}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 10)
//    {
//        Console.WriteLine("write value: ");
//        short ashort = short.Parse(Console.ReadLine());
//        Console.WriteLine($"short={ashort}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 11)
//    {
//        Console.WriteLine("write value: ");
//        ushort aushort = ushort.Parse(Console.ReadLine());
//        Console.WriteLine($"ushort={aushort}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 12)
//    {
//        Console.WriteLine("write value: ");
//        float afloat = float.Parse(Console.ReadLine());
//        Console.WriteLine($"flost={afloat}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 13)
//    {
//        Console.WriteLine("write value: ");
//        double adouble = double.Parse(Console.ReadLine());
//        Console.WriteLine($"double={adouble}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 14)
//    {
//        Console.WriteLine("write value: ");
//        decimal adecimal = decimal.Parse(Console.ReadLine());
//        Console.WriteLine($"decimal={adecimal}");
//        Console.ReadLine();
//        break;
//    }
//    else if (choise == 0) break;
//    else Console.WriteLine("incorrect answer");
//} while (true);