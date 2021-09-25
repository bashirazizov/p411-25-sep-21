using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Console.Write("Bali daxil edin: ");
            //int score;

            //while (true)
            //{
            //    try
            //    {
            //        score = Convert.ToInt32(Console.ReadLine());
            //        if (score>=0&&score<=100)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid");
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Error");
            //    }
            //}

            //if (score>=91)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score>=81)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score>=71)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (score>=61)
            //{
            //    Console.WriteLine("D");
            //}
            //else 
            //{
            //    Console.WriteLine("kesildin");
            //}
            #endregion

            #region task2
            //Console.Write("Ededi daxil edin : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //while (num>=i)
            //{
            //    if (num%i==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;
            //}
            #endregion

            #region task3
            //int num = Convert.ToInt32(Console.ReadLine());
            //int result = 0;

            //while (num>=1)
            //{
            //    num /= 10;
            //    result++;
            //}

            //Console.WriteLine(result);
            #endregion

            #region task4
            //int num = Convert.ToInt32(Console.ReadLine());
            //int result = 0;

            //while (num >= 1)
            //{
            //    result += num % 10;
            //    num /= 10;
            //}

            //Console.WriteLine(result);
            #endregion

            #region task 7

            //int[] arr = { 1, 12, 512,5 , 17 };

            //int min = arr[0];
            //int max = arr[0];

            //foreach (int item in arr)
            //{
            //    if (item>max)
            //    {
            //        max = item;
            //    }
            //    if (item<min)
            //    {
            //        min = item;
            //    }
            //}
            //Console.WriteLine(min+max);

            #endregion

            #region task10
            //for (int i = 1; i <=10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i*j}");
            //    }
            //}
            #endregion

            #region value-refrence-types
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1;
            //arr2[0] = 10;


            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);

            //int a;
            //ChangeNum(out a);
            //Console.WriteLine(a);

            //string numAsString = "salam";
            //int result;

            //if (int.TryParse(numAsString, out result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine(result);
            //    Console.WriteLine("cevire bilmedim");
            //}
            #endregion

            #region string

            //string st1= "salam";
            //string st2 = "asd"

            //Console.WriteLine(st1[2]);

            //foreach (char item in st1)
            //{
            //    Console.WriteLine(item);
            //}

            //bool isSame = String.Equals(st1, st2);
            //Console.WriteLine(isSame);

            //string concatedSt = String.Concat(st1, st2);
            //concatedSt = st1 + st2;

            //concatedSt = $"birinci soz = {st1} amma ikinci soz = {st2} belelikle iki sozun birlesmesi = {String.Concat(st1, st2)}";

            //Console.WriteLine(concatedSt);

            //for (int i = 0; i < st1.Length; i++)
            //{
            //    Console.WriteLine(st1[i]);
            //}

            //Console.WriteLine(st1.Contains("a"));

            //Console.WriteLine(st1.IndexOf('a'));
            //Console.WriteLine(st1.LastIndexOf('a'));

            //Console.WriteLine(st1.Remove(0,2));
            //Console.WriteLine(st1.Remove(2));

            //Console.WriteLine(st1.Replace('m', 't'));
            //Console.WriteLine(st1.Replace("al", "mamed"));

            //Console.WriteLine(st1.Insert(1,"mahir"));

            //Console.WriteLine(st1.StartsWith("sala"));
            //Console.WriteLine(st1.EndsWith("sa"));

            //char[] arr = st1.ToCharArray();


            //Console.WriteLine(String.IsNullOrEmpty(st1));

            //Console.WriteLine(st1.ToUpper());
            //Console.WriteLine(st1.ToLower());

            //Console.WriteLine(st1.Length);
            //Console.WriteLine(st1.Trim().Length);

            //string reverseSt1 = "";
            //for (int i = st1.Length-1; i >= 0; i--)
            //{
            //    reverseSt1 += st1[i];
            //}
            //Console.WriteLine(reverseSt1);

            //StringBuilder reverseSt1 = new StringBuilder();

            //for (int i = st1.Length - 1; i >= 0; i--)
            //{
            //    reverseSt1.Append(st1[i]);
            //}
            //string result = reverseSt1.ToString();
            //Console.WriteLine(result);

            #endregion

            #region array
            int[] arr = { 1, 2, 3, 2, 4, 0, 3123, 12 , 2 };
            string[] arr1 = { "adasd", "zsdasd", "gsdfs", "51casd" };

            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Sum());
            //Console.WriteLine(arr.Average());
            //Console.WriteLine(arr1.Contains("dasdas"));
            //Array.Sort(arr1);
            //Array.Clear(arr, 2, 3);
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(FindNumberCount(arr, 2));
            #endregion

        }

        #region value-refrence-types
        //static void ChangeNum(out int num)
        //{
        //    num = 10;
        //    Console.WriteLine(num);
        //}
        #endregion

        #region task5
        //static bool IsPrime(int num)
        //{
        //    for (int i = 2; i < num; i++)
        //    {
        //        if (num%i==0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
        #endregion

        #region task6
        //static long Factorial(int num)
        //{
        //    long result = 1;

        //    while(num>=1){
        //        result *= num;
        //        num--;
        //    }

        //    return result;
        //}
        #endregion

        #region task9
        //static string GetLongestString(params string[] arr)
        //{
        //    string longestWord = arr[0];

        //    foreach (string item in arr)
        //    {
        //        if (item.Length > longestWord.Length)
        //        {
        //            longestWord = item;
        //        }
        //    }

        //    return longestWord;
        //}
        #endregion

        static int FindNumberCount(int[] arr, int num)
        {
            int result = 0;
            foreach (int item in arr)
            {
                if (item == num) 
                {
                    result++;
                }
            }
            return result;
        }
    }
}
