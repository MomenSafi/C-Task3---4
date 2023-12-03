using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task3___4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a sample sentence.";
            int wordCount = Task17(sentence);
            Console.WriteLine($"The number of words in the sentence is: {wordCount}");

        }

        public static void Task1()
        {
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
        }
        public static void Task2()
        {
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine($"Tomato is {Array.IndexOf(fruits, "Tomato")} and Banana is {Array.IndexOf(fruits, "Banana")}");
        }
        public static void Task3()
        {
            string[] Foods = { "Warak Enab and Kousa Mahshi", "Shawarma", "Ara’yes", "Shish Kebabs", "Musakhan" };
            string[] Sports = { "Football", "Tennis", "BAsketball" };
            string[] Movies = { "the shawshank redemption", "the dark knight", "inception" };
            foreach (var item in Foods)
            {
                Console.WriteLine(item);
            }
            foreach (var item in Sports)
            {
                Console.WriteLine(item);
            }
            foreach (var item in Movies)
            {
                Console.WriteLine(item);
            }
        }
        public static void Task4()
        {
            Console.WriteLine("Enter a three numbers seperated by , like 10,20,30 to calc sum");
            string str = Console.ReadLine();
            string[] strnums = str.Split(',');
            int[] nums = Array.ConvertAll(strnums, int.Parse);
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            Console.WriteLine(sum);

        }
        public static void Task5()
        {
            int sum = 0;
            for (int i = 1; i < 100; i += 2)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine($"\n{sum}");
        }
        public static void Task6()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        public static void Task7()
        {
            int toprint = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= 4 - i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{toprint} ");
                    toprint++;
                }
                Console.WriteLine();
            }
        }
        public static void Task8(int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            double avg = (double)sum / 10;
            Console.WriteLine($"sum = {sum}, avg = {avg}");
        }
        public static void Task9()
        {
            int terms = int.Parse(Console.ReadLine());
            for (int i = 1; i <= terms; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Number is : {n} and cube of the {n} is :{Math.Pow(n, 3)}");
            }
        }
        public static void Task10(int[] years)
        {
            foreach (var item in years)
            {
                if (item > 1950)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void Task11()
        {
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(age * 365);
        }
        public static void Task12()
        {

        }
        public static string Task13(string username, string password)
        {
            string[][] Users ={
                new string[] { "user1", "password123" },
                new string[] { "user2", "pass456" },
                new string[] { "user3", "secret789" }
            };

            foreach (string[] user in Users)
            {
                if (user[0] == username && user[1] == password)
                {
                    return "Pass"; 
                }
            }

            return "Failed";
        }
        public static double Task14(int basenum, int exponentnum)
        {
            double value = 1;

            for (int i = 0; i < exponentnum; i++)
            {
                value *= basenum;
            }

            return value;
        }
        public static void Task15(int year)
        {
            if (year >= 1900 && year <= 2024)
            {
                year -= 1900;
                if (year % 4 == 0)
                {
                    Console.WriteLine(($"{year} is a leap year."));
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine("Please provide a year within the range 1900-2024.");
            }
        }
        public static bool Task16(int num)
        {
            if (num <= 1)
            {
                return false; 
            }

            
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; 
                }
            }

            return true; 
        }
        public static int Task17(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0; 
            }

            int wordCount = 1; 

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (char.IsWhiteSpace(str[i]) || char.IsPunctuation(str[i]))
                {
                    if (!char.IsWhiteSpace(str[i + 1]) && !char.IsPunctuation(str[i + 1]))
                    {
                        wordCount++;
                    }
                }
            }
            return wordCount;
        }
    }
}
