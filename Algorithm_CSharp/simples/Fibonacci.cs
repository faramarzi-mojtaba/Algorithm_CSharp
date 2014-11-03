using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp.simples
{
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Number: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Recursive aproach:");
            for (int i = 0; i < number ; i++)
            {
                if (i != number - 1)
                {
                    Console.Write(fibo(i) + ", ");
                }else{
                    Console.WriteLine(fibo(number) +"\n");
                }
            }
            Console.WriteLine("Non Recursive aproach:");
            nonRecursiveFibo(number);
            Console.ReadLine();
        }
        public static int fibo(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return fibo(n - 1) + fibo(n - 2);
        }
        public static void nonRecursiveFibo(int n)
        {
            try
            {
                int[] array = new int[n];
                #region Fibonacci sequence
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == 0 || i == 1)
                        array[i] = 1;
                    else
                        array[i] = array[i - 1] + array[i - 2];
                }
                #endregion
                #region print the sequence
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != array.Length -1)
                    {
                        Console.Write(array[i] + ", ");
                    }else
                        Console.WriteLine(array[i]);
                }
                #endregion
            }
            catch (Exception exp)
            {
                Console.WriteLine("Fibonacci --> nonRecursiveFibo " + exp.Message);                
            }
        }
    }
}
