using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 2, 3, 4 };
            foreach (int i in n)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
