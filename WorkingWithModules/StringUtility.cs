using System;
namespace WorkingWithModules
{
    public class StringUtility


    {

        //need to add in public to make it accessible
        public static string SummarizeText(string textSentence, int maxLength)
        {
            var summaryWords = new List<string>();
            var totalCharacters = 0;

            if (textSentence.Length < maxLength)
                return textSentence;
            else
            {
                var words = textSentence.Split(' ');
                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += (word.Length + 1);  //+- basically just (word.Length + 1) + totalCharcters
                    //Console.WriteLine("total characters: " + totalCharacters);
                    if (totalCharacters > maxLength)
                        break;
                }
                var summary = String.Join(" ", summaryWords);
                return summary;


            };

        }
    }
}