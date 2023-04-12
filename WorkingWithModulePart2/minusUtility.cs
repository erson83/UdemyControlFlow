using System;
namespace WorkingWithModulePart2
{
	class MinusCalculator
    {
		int num1;
		int num2;


        // Constructor to initialize the variables
        public MinusCalculator(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;

        }
        public int CalculateMinus()
        {
            return num1 - num2;
        }


    }
}

