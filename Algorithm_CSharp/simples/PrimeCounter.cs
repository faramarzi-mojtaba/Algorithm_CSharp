using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp.simples
{
    public class PrimeCounter
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter Your Number :");
                int number = Int32.Parse(Console.ReadLine());
                int counter = 0;
                for (int i = 2; i < number; i++)
                {
                    if (Prime.isPrime(i))
                        counter++;
                }
                Console.WriteLine("The number of Prime number less than " + number + " is : " + counter);
            }
            catch (Exception e)
            {
                Console.WriteLine("PrimeCounter --> main " + e.Message);
            }
        }
    }
}
