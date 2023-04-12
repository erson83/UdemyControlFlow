// See https:/using System;
using System;
using System.IO;
namespace WorkingWithFile

{
    class Program
    {
        public static void Main(string[] args)
        {
            // static method for small no. of operations
            File.Copy(@"/Users/jeffersonong/Projects/UdemyControlFlow/Working withFile/CopyFrom/EmptyTextFile.txt", @"/Users/jeffersonong/Projects/UdemyControlFlow/Working withFile/CopyTo/EmptyTextFile.txt",true);

            // instance method for large no. of operations
            var path1 = @"/Users/jeffersonong/Projects/UdemyControlFlow/Working withFile/CopyTo/EmptyTextFile.txt";
            var path2 = @"/Users/jeffersonong/Projects/UdemyControlFlow/Working withFile/CopyAgain/EmptyTextFile.txt";
            var fileInfo = new FileInfo(path1);
            fileInfo.CopyTo(path2,true);
            if (fileInfo.Exists)
            {
                Console.WriteLine("file exists");
            }

            // static method
            //"*.*" means all files inside * is a wild card
            var filepath = @"/Users/jeffersonong/Projects/UdemyControlFlow/Working withFile/CopyFrom";

            var files = Directory.GetFiles(filepath, "*.txt", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine("Files insde contain: " + file);
            }

            //instance method
            var directoryInfo = new DirectoryInfo(filepath);
            foreach (var file in directoryInfo.GetFiles())
            {
                Console.WriteLine("Files insde contain: " + file);
            }

            var path3 = @"/Users/jeffersonong/Projects/UdemyControlFlow/Working withFile/CopyAgain/EmptyTextFile.txt";
            // static method

            Console.WriteLine("Path Extension: " + Path.GetExtension(path3));
            Console.WriteLine("Path Extension: " + Path.GetFileName(path3));
            Console.WriteLine("Path Extension: " + Path.GetDirectoryName(path3));

            //excercise 1


            //The File.ReadAllLines() method opens a text file, reads all lines of the file into a string array, and then closes the file. The following code snippet reads a text file into an array of strings.
            var textFile = @"/Users/jeffersonong/Projects/UdemyControlFlow/Working withFile/CopyFrom/EmptyTextFile.txt";
            try
            {


                string[] lines = File.ReadAllLines(textFile);
                var wordCount = 0;

                foreach (string line in lines)
                {
                    // Split the input string into words based on whitespace characters (Eg. this is == 2 words)
                    string[] words = line.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;
                    Console.WriteLine(words.Length);
                    Console.WriteLine(line);
                }

                Console.WriteLine("wordcount: " + wordCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }


        }

    }

}