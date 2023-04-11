using System;
using System.Collections.Generic;

namespace ArraysList

{
    class Program

    {
        static void Main(string[] args)
        {
            // declaring a rectangular 2D array
            //3 rows by 5 column
            var matrix = new int[3, 5]
            {
                { 1,2,3,4,5 },
                                { 1,2,3,4,5 },
                                                { 1,2,3,4,5 }
            };


            // declaring jagged array
            var jaggedMatrix = new int[3][];
            jaggedMatrix[0] = new int[4]
            {
                      1,2,3,4
            };
            jaggedMatrix[0] = new int[1]
            {
                      10
            };
            jaggedMatrix[0] = new int[2]
            {
                      100,200
            };

            //declaring empty array

            var numberArrays = new int[] {1,2,3,4,5 };
            Console.WriteLine("lenght of array: " + numberArrays.Length);

            // index(of) to search array that matches criteria and give index of position
            var indexPosition = Array.IndexOf(numberArrays, 4);
            Console.WriteLine("Index of array for {0} is at {1}",4,indexPosition);

            // clear() starting from index of x to index of y (eg. 0 to 3)
            // clearing int means set to zero
            // clearing boolean means set to false
            //clearing string mean set to null
            Array.Clear(numberArrays, 0, 3);
            foreach (var n in numberArrays)
                Console.WriteLine("each number in arrays are: " + n);


            //copy() copy from one array to anotherArray , will copy from 1st array onto 4th array
            // if nothing to copy, default is 0
            int[] anotherArray = new int[6];
            Array.Copy(numberArrays, anotherArray, 4);
            foreach (var n in anotherArray)
                Console.WriteLine("each number in copy array are: " + n);

            //sorting list
            var unsortedArray = new int[] { 6, 2, 9, 4, 5 };
            Array.Sort(unsortedArray);
            Console.WriteLine("sorted array:"+ String.Join(";",unsortedArray));
            Array.Reverse(unsortedArray);
            Console.WriteLine("Reversed array:" + String.Join(";", unsortedArray));


            var numbersList = new List<int>() {1,2,3,4 };
            numbersList.Add(5);
            numbersList.AddRange(new int[7] { 6, 7, 8 , 1,1,1,1});
            Console.WriteLine("list: " + String.Join(";",numbersList));

            // writing index of

            Console.WriteLine("index of 1: " + numbersList.IndexOf(1));
            Console.WriteLine("index of 1: " + numbersList.LastIndexOf(1));
            Console.WriteLine("Count no. : "+ numbersList.Count);

            numbersList.Remove(1);
            Console.WriteLine("list: " + String.Join(";", numbersList));

            // to remove all the 1 inside the list
            // cannot use foreach method to remove, can only use for method
            for (var i = 0; i<numbersList.Count; i++)
            {
                if (numbersList[i] == 1)
                    numbersList.Remove(numbersList[i]);
            }


            Console.WriteLine("list: " + String.Join(";", numbersList));


            // using Clear
            numbersList.Clear();
            Console.WriteLine("list: " + String.Join(";", numbersList));


            //excecise 1

            string inputNameVar;
            var arrayName = new List<string>();

            while (true)
            {

                Console.Write("Enter a name - ");
                inputNameVar = Console.ReadLine();


                if (!String.IsNullOrEmpty(inputNameVar))
                {
                    Console.WriteLine("you entered {0}", inputNameVar);
                    arrayName.Add(inputNameVar);
                }
                else
                {
                    Console.WriteLine("no name entered");
                    break;

                }
            }
            Console.WriteLine("Total names of lists added: " + String.Join(";", arrayName));


            int arrayCount = arrayName.Count;
            Console.WriteLine("arrayCount: " + arrayCount);
            switch (arrayCount)
            {
                case 0:
                    Console.WriteLine("0 likes");
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post", arrayName[0]);
                    break;
                case 2:
                    Console.WriteLine(String.Format("{0} and {1} like your post", arrayName[0], arrayName[1]));
                    break;
                default:
                    Console.WriteLine(String.Format("{0},{1}, and {2} others like your post", arrayName[0], arrayName[1],arrayCount -2));

                    break;


            

            }

        }

        }



    }

