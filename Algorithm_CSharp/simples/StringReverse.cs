using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp.simples
{
    public class StringReverse
    {
        public static void demo()
        {
            try
            {
                Console.WriteLine("Please Enter Your String: ");
                String str = Console.ReadLine();
                Console.WriteLine("Recursive Approach Result:");
                Console.WriteLine(recursiveReverse(str));
                Console.WriteLine("Non Recursive Approach Result:");
                Console.WriteLine(nonRecursiveReverse(str));
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("StringReverse --> main " + e.Message);
            }
        }
        public static string recursiveReverse(string str)
        {
            if (str.Length < 2) return str;
            else return recursiveReverse(str.Substring(1)) + str[0];
        }
        public static string nonRecursiveReverse(string str)
        {
            string result = "";
            try
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    result += str[i];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("StringReverse --> nonRecursiveReverse " + e.Message);
            }
            return result;
        }
    }
}
