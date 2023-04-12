using System;
using System.Xml;

namespace ProceduralProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {

            var numbers = new List<int>();
            while(true)
            {
                Console.WriteLine("Enter a number (or Quit to exit):");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {

                    numbers.Add(Convert.ToInt32(input));
                }


            }
            Console.WriteLine(String.Join(";",numbers));

            var uniques = GetUniqueNumbers(numbers);

            Console.WriteLine("Unique numbers are:" + String.Join(";", uniques));
            //            Console.WriteLine("Unique numbers are:" + String.Join(";", GetUniqueNumbers(numbers)));

        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {

            var uniques = new List<int>();
            foreach (var num in numbers)
            {
                if (!uniques.Contains(num))
                    uniques.Add(num);

            }

            return uniques;


        }

    }

}