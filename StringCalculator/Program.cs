using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            // Test cases
            Console.WriteLine(calculator.Add(""));        // Output: 0
            Console.WriteLine(calculator.Add("1"));       // Output: 1
            Console.WriteLine(calculator.Add("1,2"));     // Output: 3
            Console.WriteLine(calculator.Add("1\n2,3"));  // Output: 6
            Console.WriteLine(calculator.Add("//;\n1;2")); // Output: 3

            try
            {
                // Negative numbers test
                Console.WriteLine(calculator.Add("-1,2")); // Throws exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
