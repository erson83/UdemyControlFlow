using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // converting numbers to string

            int i = 1234;
            string s = i.ToString();
            Console.WriteLine(i);
            string t = i.ToString("C"); // format to currency with 2 decimal
            Console.WriteLine(t);
            string q = i.ToString("C0"); // format to currency with 0 decimal place
            Console.WriteLine(q);
            string r = i.ToString("D"); // format to currency with 0 decimal place
            Console.WriteLine(r);

            var fullName = "Jefferson Ong";
            var indexName = fullName.IndexOf(' '); // counts up until the spacing
            var firstName = fullName.Substring(0, indexName);
            var lastName = fullName.Substring(indexName + 1);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // using split string
            var namesVar = fullName.Split(' ');

            Console.WriteLine(namesVar[0]);
            Console.WriteLine(namesVar[1]);

            Console.WriteLine(String.IsNullOrEmpty(" ")); // false outcome as a space is not considered empty
            Console.WriteLine(String.IsNullOrEmpty("")); // true outcome
            Console.WriteLine(String.IsNullOrWhiteSpace(" ")); // true outcome, a space is considered white space
            var sentence = "this is a really long test..........";
            const int maxLength = 10;
            var summaryWords = new List<string>();
            var totalCharacters = 0;


            if (sentence.Length < maxLength)
                Console.WriteLine(sentence);
            else {
                var words = sentence.Split(' ');
                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += (word.Length + 1);  //+- basically just (word.Length + 1) + totalCharcters
                    Console.WriteLine("total characters: " + totalCharacters);
                    if (totalCharacters > maxLength)
                        break;
                }
                var summary = String.Join(" ", summaryWords);
                Console.WriteLine(summary);


            };





        }




    }
}

