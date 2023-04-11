using System.Text.RegularExpressions;

namespace Conditionals

{
    class Program

    {
        static void Main(string[] args)

        {
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("afternoon");
            }
            else
            {
                Console.WriteLine("night");
            }


            //

            bool isGoldCustomer = true;
            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 20.25f;



            //alternative faster method

            float price = (isGoldCustomer) ? 19.95f : 20.25f;
            Console.WriteLine("Price is: " + price);




            var seasonVar = Season.Winter;

            switch (seasonVar)

            {
                case Season.Autumn:
                    Console.WriteLine("Autumn");
                    break;
                case Season.Summer:
                case Season.Winter:
                    Console.WriteLine("Summer or Winter");
                    break;
                default:
                    Console.WriteLine("no season");
                    break;



            }


            var careerFit = CoursesEnum.Engineering;

            switch (careerFit)
            {
                case CoursesEnum.Banking:
                case CoursesEnum.Biology:
                case CoursesEnum.Engineering:
                    Console.WriteLine("candidate not match IT criteria");
                    break;
                case CoursesEnum.IT:
                    Console.WriteLine("cadidate meets IT criteria");
                    break;
                default:
                    break;




            }


            var numberChoice = 5;
            if (numberChoice >= 1 && numberChoice <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

            var numberSelection1 = 1001;
            var numberSelection2 = 200;
            Console.WriteLine("Maxinum of both numbers:" + Math.Max(numberSelection1, numberSelection2));



            var width = 1000;
            var length = 1000;
            if (width > length)
                Console.WriteLine("landscape");
            else if (width < length)
                Console.WriteLine("potrait");
            else
                Console.WriteLine("square");


            //type ur speed to check if you are overlimit

            string inputString;
            Console.Write("Enter a speed limit - ");
            inputString = Console.ReadLine();
            Console.WriteLine("your entered speedlimit is {0}", inputString);

            int inputSpeedLimit;
            inputSpeedLimit = Convert.ToInt32(inputString);

            if (inputSpeedLimit < 60)
                {
                Console.WriteLine("you are within speed limit");
                }
            else
                {
                decimal demeritPoint = ((inputSpeedLimit - 60) / 5);
                Console.WriteLine("demeritPoint in decimal values: " + demeritPoint);
                var demeritPointRoundedOff = Math.Round(demeritPoint, 0);

                switch (demeritPoint)
                    {
                    case 1:
                        Console.WriteLine("one demerit point");
                        break;
                    case 2:
                        Console.WriteLine("two demerit point");
                        break;
                    case 3:
                        Console.WriteLine("3 demerit point");
                        break;
                    case 4:
                        Console.WriteLine("4 demerit point");
                        break;
                    case 5:
                        Console.WriteLine("5 demerit point");
                        break;
                    case 6:
                        Console.WriteLine("6 demerit point");
                        break;
                    case 7:
                        Console.WriteLine("7 demerit point");
                        break;
                    case 8:
                        Console.WriteLine("8 demerit point");
                        break;
                    case 9:
                        Console.WriteLine("9 demerit point");
                        break;
                    case 10:
                        Console.WriteLine("10 demerit point");
                        break;
                    case 11:
                        Console.WriteLine("11 demerit point");
                        break;
                    case 12:
                        Console.WriteLine("12 demerit point.");
                        break;
                    default:
                        Console.WriteLine("License Suspended");
                        break;
                      }
                Console.WriteLine("you are above speed limit");
                 }

            // for anything u wana loop
            for (var k = 1; k<=10; k++)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
            }

            // using while, although we can also use for loop. its the same result
            var p = 0;
            while (p <= 10)
            {
                if (p % 2 == 0)
                {
                    Console.WriteLine(p);
                }
                    p++;        //have to be careful where this is placed inside while loop
                
            }

            //we use while loop when we do not KNOW the no.of iterations.
            //we can use a true condition until be becomes false and breaks out of it


            string inputTestingVar;
            while (true)
            {

                Console.Write("Enter a letter. type b to end - ");
                inputTestingVar = Console.ReadLine();
                Console.WriteLine("your entered {0}", inputTestingVar);

                if (inputTestingVar == "b")
                {
                    Console.WriteLine("met condition, loop will break");
                    break;
                }
                else { };

            }

            //another while loop

            while (true)
            {
                Console.WriteLine("Type your name: ");
                var inputName = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputName))
                {
                    Console.WriteLine("you did not enter anything. enter something");
                    continue;
                }

                else if (!String.IsNullOrWhiteSpace(inputName))
                {
                    Console.WriteLine("you entered: " + inputName);
                    break;
                }

            }




            // string is an iterable object

            var name = "John Smith";
            for (var j=0; j<name.Length; j++)
            {
                Console.WriteLine(name[j]);

            }

            // for list or array nature, we use foreach
            foreach (var character in name)
            {
                Console.WriteLine(character);

            }

            var numberArrays = new int[3] {9,99,999 };

            foreach (var num in numberArrays)
            {

                Console.WriteLine(num);

            }

            {
                // creating password using random
                var random = new Random();

                var buffer = new char[10];
                for (var i = 0; i < 10; i++)
                    buffer[i] = (char)(random.Next(97, 122));
                    Console.Write((char)(random.Next(97, 122)));
                    var password = new string(buffer);
                    //www.theasciicode.com.ar/ascii-printable-characters/lowercase-letter-z-minuscule-ascii-code-122.html
                    Console.WriteLine(password);
            }


            {
                //excercise 1
                var counter = 0;
                for (var i=1;i<=100; i++)
                {
                    if (i%3 == 0)
                    {
                        counter++;
                    }


                }
                Console.WriteLine("no. of time is divisible by 3: " + counter);


            }
            {
                // excercise 2
                string inputNumberStr;
                while (true)
                {

                    Console.Write("Enter a number and ok to exit - ");
                    inputNumberStr = Console.ReadLine();
                    Console.WriteLine("your entered value: {0}", inputNumberStr);
                    if (Regex.IsMatch(inputNumberStr, @"^\d+$"))
                    {
                        continue;
                    }
                    else if (inputNumberStr == "ok")
                    {
                        Console.WriteLine("ok is entered.");
                        break;
                    }


                }
            }

            {
                string inputFactorialStr;
                int inputFactorialNo;
                int finalValue = 1;
                // excercise 3
                Console.Write("Enter a factorial number: ");
                inputFactorialStr = Console.ReadLine();
                Console.WriteLine("your entered value: {0}", inputFactorialStr);

                inputFactorialNo = Convert.ToInt32(inputFactorialStr);
                for (int i = 1; i<= inputFactorialNo; i++)

                {
                    finalValue = finalValue * i;
                }

                Console.WriteLine("Final value of facotiral: " + finalValue);
            }



        }

        

    }





    }




