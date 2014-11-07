using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp.simples
{
    public class Factorial
    {
        public static void demo()
        {
            try
            {
                Console.WriteLine("Please Enter Your Number:");
                int input = Int32.Parse(Console.ReadLine());
                if (input > 0)
                {
                    Console.WriteLine("Recursive approach:");
                    Console.WriteLine(recursiveFactorial(input));

                    Console.WriteLine("Non Recursive approach:");
                    Console.WriteLine(nonRecursive(input));
                }
                else
                {
                    Console.WriteLine("Please enter proper number!");
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Factorial --> main " + e.Message);
            }
        }
        public static long recursiveFactorial(int n)
        {
            if (n != 1)
                return recursiveFactorial(n - 1) * n;
            else
                return 1;
        }
        public static long nonRecursive(int num)
        {
            int result = 1;
            if (num == 1)
                result = 1;
            else
            {
                for (int i = num; i > 0; i--)
                {
                    result *= num;
                    num--;
                }
            }
            return result;
        }
    }
}
