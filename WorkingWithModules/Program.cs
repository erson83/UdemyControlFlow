// See httpsusing System;

using WorkingWithModules;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence1 = "this is a really really long text";
            var summary1 = StringUtility.SummarizeText(sentence1,10);
            Console.WriteLine(summary1);

            var sentence2 = "this short";
            var summary2 = StringUtility.SummarizeText(sentence2, 10);
            Console.WriteLine(summary2);

            var sentence3 = "this is a really really really really really long text";
            var summary3 = StringUtility.SummarizeText(sentence3, 20);
            Console.WriteLine(summary3);


        }



     }



}
