using System;
using System.Text;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            //use string builder to make it more cost effective
            //StringBuilder only provides methods for fast and efficient manipulation of strings. It doesn't have any methods to search in strings. 
            var builder = new StringBuilder();
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("testing")
                .AppendLine()
                .Append('-', 10)
                .AppendLine();
            Console.WriteLine(builder);

            var builder2 = new StringBuilder();
            builder2
                .Append('-', 10)
                .AppendLine()
                .Append("testing")
                .AppendLine()
                .Remove(0, 15)  //remove up till first 5 index
                .AppendLine();
            Console.WriteLine(builder2);

            var builder3 = new StringBuilder();
            builder3
                .Append('-', 10)
                .AppendLine()
                .Append("testing")
                .AppendLine()
                .Replace('-', '*')  //remove up till first 5 index
                .AppendLine();
            Console.WriteLine(builder3);



        }



    }



}
