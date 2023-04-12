using System;
namespace WorkingWithModulePart2
{
        class SumCalculator
        {
            int num1;
            int num2;

            // Constructor to initialize the variables
            public SumCalculator(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }

            // Method to calculate the sum
            public int CalculateSum()
            {
                return num1 + num2;
            }
        }
    }
