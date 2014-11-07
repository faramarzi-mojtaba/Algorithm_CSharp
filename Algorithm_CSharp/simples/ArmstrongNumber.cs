using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_CSharp.simples
{
    class ArmstrongNumber
    {
        public static void demo()
        {
            try
            {
                Console.WriteLine("Please enter a 3 digit number to find if its an Armstrong number:");
                Int32 input = Int32.Parse(Console.ReadLine());
                if (isArmstrong(input))
                {
                    Console.WriteLine("Number : " + input + " is an Armstrong number");
                }
                else
                {
                    Console.WriteLine("Number : " + input + " is not an Armstrong number");
                }
                Console.ReadLine();
            }
            catch (Exception exp)
            {
                Console.WriteLine("armstrongNumber --> main "+exp.Message);
            }
            
        }
        public static bool isArmstrong(int input)
        {
            try
            {
                int original = input;
                int result = 0;
                while (input !=0)
                {
                    int reminder = input % 10;
                    result += reminder * reminder * reminder;
                    input /= 10;
                }
                if (original == result)
                {
                    return true;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Armstrong --> isArmstrong "+exp.Message);
            }
            return false;
        }
    }
}
