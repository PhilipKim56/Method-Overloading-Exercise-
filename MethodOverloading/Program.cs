using System.Net.NetworkInformation;
using System;
using System.Runtime.CompilerServices;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine(Add(0.54m, 0.12m, true));

            Console.WriteLine(Add(5, 9, true));

            Console.WriteLine(Add(0.54m, 0.46m, true));

            Console.WriteLine(Add(0.54, 0.12));

            Console.WriteLine(Add(786, 575));

        }


        //Create a method named Add, that accepts two integers and returns the sum of those two integers

        public static int Add(int x, int y) 
        {
            return x + y;
        }
        //Now create an overload of the Add method to account for being able to add two decimals together
        public static double Add(double x, double y)  
        {
            return x + y;
        }

        //Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
        public static string Add(decimal x, decimal y, bool isTrue) 
        {
            var sum = x + y;

            if(isTrue == true && sum > 1) 
            {
                return $"{sum} dollars";
            }
            else if(isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(isTrue == true && sum < 1)
            {
                return $"{sum} cents";
            }
            else
            {
                return sum.ToString() ;
            }
        }

        //If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
        //You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
        //For example:

        //“5 dollars”

        //"1 dollar”

        //“16 dollars”

    }
}
