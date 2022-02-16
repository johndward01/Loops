using System;
using System.Collections.Generic;

namespace Iteration_Statements_Demo
{
    class Program
    {
        public enum Keys { F1, F2, F3, F4 };

        static void Main(string[] args)
        {
            var namesArray = new string[] { "Jo", "John", "Jon", "V", "Marina" };
            var namesList = new List<string>() { "John", "Jack", "Ted", "Sue", "Marty", "john" };
            var numbers = new List<int>() { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            var myList = new List<int>() { 1, 2, 3 };
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var list = new List<int> { 1000, 2000, 3000, 4000, 5000, 6000, 7000 };

            #region DO-WHILE LOOPS

            var index2 = 0;

            do
            {
                Console.WriteLine(list[index2]);
                index2++;
            } while (index2 < list.Count);


            var j = 0;

            do
            {
                Console.Write($"{j} ");
                ++j;
            } while (j < 10);


            int counter1 = 10;

            do
            {
                Console.WriteLine(counter1);
                counter1--;
            } while (counter1 > 0);


            int counter2 = 10;

            do
            {
                if (counter2 % 2 == 0)
                {
                    Console.WriteLine(counter2);
                }
                counter2--;
            } while (counter2 > 10);

            #endregion

            #region WHILE LOOPS

            int counter3 = 10;

            while (counter3 > 0)
            {
                Console.Write(counter3);
                counter3--;
            }


            var userInput = "";
            var guess = 0;
            var favNumber = 7;

            while (true)
            {
                Console.WriteLine("Guess a number");
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (guess < favNumber)
                {
                    Console.WriteLine("too low");
                }
                else if (guess > favNumber)
                {
                    Console.WriteLine("too high");
                }
                else
                {
                    Console.WriteLine("You got the right answer!");
                    break;
                }
                Console.WriteLine();
            }


            var counter4 = 0;

            while (true)
            {
                Console.WriteLine(counter4);
                counter4--;

                if (counter4 == -10)
                {
                    break;
                }
            }


            var index1 = 0;

            while (index1 < list.Count)
            {
                Console.WriteLine(list[index1]);
                index1++;
            }

            #endregion

            #region FOR LOOPS

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }


            for (int i = 0; i < namesArray.Length; i++)
            {
                Console.WriteLine(namesArray[i]);
            }


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            for (int i = 0; i < namesList.Count; i++)
            {
                if (namesList[i][0] == 'J' || namesList[i][0] == 'j')
                {
                    Console.WriteLine(namesList[i]);
                }
            }


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            #endregion

            #region FOREACH LOOPS

            foreach (var item in namesList)
            {
                Console.WriteLine(item);
            }


            foreach (var x in numbers)
            {
                Console.WriteLine(x);
            }


            foreach (var number in myList)
            {
                Console.WriteLine(number);
            }


            foreach (var number in myList)
            {
                Console.WriteLine(number);
            }


            foreach (var name in namesArray)
            {
                if (name[0] == 'J' || name[0] == 'j')
                {
                    Console.WriteLine(name);
                }
            }


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }

            #endregion

        }
    }
}
