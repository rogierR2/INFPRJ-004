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
            Random r = new Random();
            int num1 = r.Next(100);
            int num2 = r.Next(100);
            int sum = num1 + num2;
            string sums = sum.ToString();
            string nums1 = num1.ToString();
            string nums2 = num2.ToString();
            Console.WriteLine(nums1 + " " + "+" + " " + nums2 + " " + "=" + "?");
            string input = Console.ReadLine();
            if (input == sums)
            {
                Console.WriteLine("correct");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong" + " " + sum);
                Console.ReadKey();
            }
            Console.ReadKey();
        }


    }
}
