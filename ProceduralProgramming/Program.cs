using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProceduralProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("What is you name?");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);


        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)

                array[name.Length - i] = name[i - 1];

            return new string(array);

        }




    }

}