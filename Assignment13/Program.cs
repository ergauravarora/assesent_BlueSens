using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Example usage of the sum method
            int result = sum(5, 3);
            Console.WriteLine("The sum is: " + result);
        }

        // Method that returns the sum of two integers
        public static int sum(int a, int b)
        {
            return a + b;
        }
    }
}
