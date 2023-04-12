using System;
namespace WorkingWithModulePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of SumCalculator
            SumCalculator calculator = new SumCalculator(5, 7);

            // Call the CalculateSum method to get the result
            int result = calculator.CalculateSum();

            // Display the result
            Console.WriteLine("Sum: " + result);

            //////////////////////////////////////////////////////////////////

            //Create an instance of MinusCalculator
            MinusCalculator calculator2 = new MinusCalculator(5, 7);

            // Call the MinusCalulor method to get the result
            int minusresult = calculator2.CalculateMinus();

            // Display the minus result
            Console.WriteLine("Minus: " + minusresult);



        }



    }
}