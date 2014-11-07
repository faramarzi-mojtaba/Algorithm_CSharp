using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp.simples
{
    public class PwerOfTwo
    {
        public static void demo()
        {
            try
            {
                Console.WriteLine("Please Enter Your Number :");
                int number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Recursive Approach Result:");
                Console.WriteLine("2 ^ " + number + " is : " + recursivePower(number));
                Console.WriteLine("Non Recursive Aproach Result:");
                Console.WriteLine("2 ^ " + number + " is : " + nonRecursivePower(number));
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("PowerOfTwo --> main " + e.Message);
            }

        }
        public static long recursivePower(int n)
        {
            if (n == 0) return 1;
            else if (n == 1) return 2;
            else return recursivePower(n - 1) * 2;
        }
        public static long nonRecursivePower(int n)
        {
            int[] array = new int[n + 1];
            try
            {
                array[0] = 1;
                for (int i = 1; i <= n; i++)
                {
                    array[i] = array[i - 1] * 2;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("PowerOfTwo --> nonRecursive " + e.Message);
            }
            return array[n];
        }
    }
}
