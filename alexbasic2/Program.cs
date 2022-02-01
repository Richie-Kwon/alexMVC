using System;
using System.Collections.Generic;

namespace alexbasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int cel = 12;
            double fire = (cel * 9 / 5) + 32;
            string option = args[0];
            Console.WriteLine(option);

            // mcs : C# compiler, mono - Mono runtime
            List<int> numberList = new List<int>();
            numberList.Add(32);
            numberList.Add(91);
            foreach (var s in numberList)
            {
                Console.WriteLine(s);
            }
        }

        static int[] Getallscores()
        {
            int[] scores = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            return scores;
        }

        static IEnumerable<int> GetNumber()
        {
            yield return 10;
            yield return 20;
            yield return 30;
            
        }
    }
} 