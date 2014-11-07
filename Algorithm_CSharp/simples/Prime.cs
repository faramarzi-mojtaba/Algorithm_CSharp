using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp.simples
{
    public class Prime
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Your Number Please :");
                int number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your Number Is Prime Number : " + isPrime(number));
            }
            catch (Exception e)
            {
                Console.WriteLine("Prime --> main " + e.Message);
            }
        }
        public static bool isPrime(int number)
        {
            try
            {
                for (int i = 2; i * i < number; i++)
                {
                    if (number % i == 0)
                        return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Prime --> isPrime " + e.Message);
            }
            return true;
        }
    }
}
