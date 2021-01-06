using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.1;
            double b = 2.1;
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

            double c, d;
            c = 3.7;
            d = 6.25;
            Console.WriteLine("{0} - {1} = {2}", c, d, c - d);

            double e, f, add;
            e = 5.0;
            f = 2.1;
            add = e * f;
            Console.WriteLine("{0} * {1} = {2}", e, f, add);

            double g, h;
            g = 2.2;
            h = 0.1;
            Console.WriteLine("{0} / {1} = {2}", g, h, g / h);

            int ab = 2;
            double i, j, k, l;
            i = 1.34;
            j = 2.12;
            k = 3.4;
            l = 10.0;
            Console.WriteLine("{0} * ({1} + {2}) + {3} / {4} = {5}", ab, i, j, k, l, ab * (i + j) + k / l);

        }
    }
}
