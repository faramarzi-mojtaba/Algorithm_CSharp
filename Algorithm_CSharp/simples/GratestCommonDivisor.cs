using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp.simples
{
    public class GratestCommonDivisor
    {
        public static void demo()
        {
            try
            {
                Console.WriteLine("Enter Your First Number:");
                int p = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Second Number:");
                int q = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Recursive Approach Result:");
                Console.WriteLine(recursiveGcd(p, q));
                Console.WriteLine("Non Recursive Approach Result:");
                Console.WriteLine(nonRecursiveGcd(p, q));
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("GreatestCommonDivisor --> main " + e.Message);
            }
        }
        public static int recursiveGcd(int p, int q)
        {
            if (q == 0) return p;
            else return recursiveGcd(q, p % q);
        }
        public static int nonRecursiveGcd(int p, int q)
        {
            try
            {
                while (q != 0)
                {
                    int temp = q;
                    q = p % q;
                    p = temp;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("GratestCommonDivisor --> nonRecursiveGcd " + e.Message);
            }
            return p;
        }
    }

}
