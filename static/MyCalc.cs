using System;
using System.ComponentModel.Design.Serialization;
using System.Threading;

namespace Static
{
    public static class MyCalc
    {
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        private static int counter;

        static MyCalc()
        {
            counter = 0;   
        }

        private static object objLock = new object();

        public static int NextCount
        {
            get { return Interlocked.Increment(ref counter); }
        }
    }
}