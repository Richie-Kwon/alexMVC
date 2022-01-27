using System;
using System.Text;

namespace alexbasic
{
    class Program
    {
        enum Yera
        {
            Fishing,
            Cooking,
            Boarding
        }

        [Flags]
        enum Boarder
        {
            None =0,
            Top =1,
            Right=2,
            Bottom=4,
            Left=8
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = "richie";
            Console.WriteLine(name);

            // int[] a = new int[100];
            // for (int i=0 ; i<100; i++)
            // {
            //     a[i] = i + 1;
            // }

            // int[] b = new int[] { };
            // b[0] = 7;
            // for (int i = 0; i <100; i++)
            // {
            //     b[i] = i ;
            // }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i.ToString());
            }

            Boarder b = Boarder.Bottom | Boarder.Left | Boarder.Right | Boarder.Top;
            if (b.HasFlag(Boarder.Bottom))
            {
                Console.WriteLine(b.ToString());
            }

        }
    }
}