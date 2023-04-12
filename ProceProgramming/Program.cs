﻿using System;
using System.Xml;

namespace ProceProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {


            // excercise 1
            var numbers = new List<int>();
            while (true)
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
            Console.WriteLine(String.Join("-", numbers));
            var isConsecutiveBool = IsConsecutive(numbers);
            Console.WriteLine("Is conseuctive: " + isConsecutiveBool);


            // excercise 2
            var numbers2 = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number (or enter to exit):");
                var input2 = Console.ReadLine();
                if (input2.ToLower() == "")
                {
                    break;
                }
                else
                {

                    numbers2.Add(Convert.ToInt32(input2));
                }
            }
            Console.WriteLine(String.Join("-", numbers2));
            var isDuplicateFoundStr = isDuplicateFound(numbers2);
            Console.WriteLine("Duplicate found?: "+ isDuplicateFoundStr);

        }

            public static bool IsConsecutive(List<int> numbers)
            {
                for (var i = 0; i < (numbers.Count - 1); i++)
                {
                    if (numbers[i + 1] >= numbers[i])
                    {
                        Console.WriteLine(numbers[i]);
                    }
                    else
                        return false;
                    break;

                }
                return true;

            }

            public static string isDuplicateFound(List<int> numbers2)
            {
                // using HashSet to keep track of unique values
                HashSet<int> set = new HashSet<int>();
                foreach (var num2 in numbers2)
                {
                    if (set.Contains(num2))
                    {
                     return "Duplicate Found";
                    }
                    else
                    {
                    set.Add(num2);
                    }

                }
                return "No duplicate found";

        }

            

     }

}