using Microsoft.Win32;
using System;
using System.Collections;
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
        public static int Task18(int min)
        {
            return min * 60;
        }
        public static int Task19(int num)
        {
            return num + 1;
        }
        public static int Task20(int[] num)
        {
            return num[0];
        }
        public static double Task21(int baseLength, int height)
        {
            return 0.5 * baseLength * height;
        }
        public static int[] Task22(int[] nums)
        {
            return nums.Where((num, index) => index % 2 == 0 && num % 2 == 0).ToArray();
        }
        public static string[] Task23(string[] strings)
        {
            return strings.Where((str, index) => index % 2 == 0 && str.Length % 2 != 0).ToArray();
        }
        public static int[] Task24(int[] nums)
        {
            return nums.Select((num, index) => (int)Math.Pow(num, index)).ToArray();
        }
        public static int Task25(int num1, int num2)
        {
            int result = 0;
            for (int i = 0; i < num2; i++)
            {
                result += num1;
            }
            return result;
        }
        public static int Task26(int start, int end)
        {
            int result = 1;
            for (int i = start; i <= end; i++)
            {
                result *= i;
            }
            return result;
        }
        public static double Task27(int[] nums)
        {
            return nums.Average();
        }
        public static int Task28(DateTime start, DateTime end)
        {
            TimeSpan result = end - start;
            return result.Days;
        }
        public static string[] Task29(string[] str)
        {
            List<string> result = new List<string>();
            foreach (var item in str)
            {
                if (isNum(item))
                {
                    result.Add(item);
                }

            }

            return result.ToArray();

            
        }
        public static bool isNum(string str)
        {
            foreach (var item in str)
            {
                if(char.IsDigit(item))
                    return true;
            }
            return false;

        }
        public static string Task30(string str)
        {
            
            string[] data = str.Split(' ');
            
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Length % 2 != 0)
                {
                    char[] charArray = data[i].ToCharArray();
                    Array.Reverse(charArray);
                    data[i] = new string(charArray);
                }
            }
            str = string.Join(" ", data);
            return str;
        }
        public static bool Task31(long num)
        {
            string numStr = num.ToString();
            string allDigits = "0123456789";

            foreach (char digit in allDigits)
            {
                if (!numStr.Contains(digit))
                {
                    return false;
                }
            }

            return true;
        }
        public static int Task32(int num1,int num2) 
        {
            return num1 + num2;
        }
        public static string Task33(string str)
        {
            double num = double.Parse(str);
            str = num.ToString();
            return str;
        }
        public static int Task34(int[] nums)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            return nums[1];
        }
        public static bool Task35(int num)
        {
            return num >= 0 ? true : false;
        }
        public static string Task36(string str)
        {
            string[] data = str.Split(' ');
            Array.Reverse(data);
            return string.Join(" ",data);
        }
        public static void Task37(int[] nums)
        {
            string[] stringNums = nums.Select(x => x.ToString()).ToArray();
            foreach (var item in stringNums)
            {
                if(item.Contains("7")) 
                {
                    Console.WriteLine("Boom!");
                    return;
                }   
            }
            Console.WriteLine("there is no 7 in the array");

        }
        public static void Task38(string str)
        {
            for (int i = 0; i < str.Length-1; i++)
            {
                if (char.IsUpper(str[i + 1]))
                {
                    str = str.Insert(i+1,' '.ToString());
                    i++;
                }
            }
            Console.WriteLine(str);
        }
        public static int Task39(bool[] str)
        {
            int count = 0;
            foreach (var item in str) 
            {
                if(item == true)
                    count++;
            }

            return count;
        }
        public static string Task40(string input)
        {
            string result = null;
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    result.Append(c);
                }
            }
            
            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        public static bool Task41(string[] str)
        {
            string result= null;
            for (int i = 0; i < str.Length - 1; i++)
            {
                result += str[i];
            }
            return result == str[str.Length - 1] ? true : false;
        }
        public static int Task42(double[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (double.IsNaN(nums[i]))
                    return i;
            }
            return -1;
        }
        public static List<string> Task43(string[] str)
        {
            List<string> result = new List<string>();
            result.Add(str[0]);
            bool cheek = false;
            for (int i = 0; i < str.Length; i++)
            {
                cheek = false;
                for (int j = 0; j < result.Count; j++)
                {
                    if (result[j] == str[i])
                    {
                        cheek = true;
                    }
                }
                if(!cheek)
                    result.Add(str[i]);
            }

            return result;
        }
        public static string Task44(string s)
        {
            if (s[8] == 'A')
            {
                s = s.Remove(s.Length - 2);

                if (s.Substring(0, 2) == "12")
                {
                    string hour = s.Substring(0, 2);
                    hour = "00";
                    s = hour + s.Substring(2);
                }
            }
            else
            {
                s = s.Remove(s.Length - 2);
                if (s.Substring(0, 2) != "12")
                {
                    string hour = s.Substring(0, 2);
                    int hours = int.Parse(hour) + 12;
                    hour = hours.ToString();
                    s = hour + s.Substring(2);
                }

            }

            return s;
        }
        public static string Task45(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char lastChar = words[i][words[i].Length-1];

                foreach (var item in vowels)
                {
                    if (lastChar == item)
                        words[i] = words[i].Remove(words[i].Length - 1);
                }
            }

            string result = string.Join(" ", words);
            return result;
        }
        public static int[] Task46(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int)Math.Pow(nums[i], 3);
            }
            return nums;
        }
    }
}