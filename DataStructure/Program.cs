using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DataStructure.LinkedLists;
using DataStructure.Stacks;
using DataStructure.Tree;
using DataStructure.Queue;
using DataStructure.Algorithms;
namespace DataStructure
{

    internal class Program
    {
        public static string oddsVsEvens(int num)
        {
            // write your code here
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }

            if (oddSum == evenSum)
            {
                return "equal";
            }
            else if (oddSum > evenSum)
            {
                return "odd";
            }
            else 
            {
                return "even";
            }
        }
            static void Main(string[] args)
        {
            string date = date_format("2019/12/28");
            Console.WriteLine(date);
            
            Console.ReadKey();
        }

        public static string date_format(string date)
        {
            // write your code here
            string formatOne = date;
            string formatTwo = date.Replace('/', '-');
            string formatThree = String.Format(formatOne, formatTwo);
            
           
            return formatOne + " | " + formatTwo + " | " + formatThree;

        }

        public static void Swap(ref char x, ref char y)
        {
            char temp = x;
            x = y;
            y = temp;
        }
    }
}
