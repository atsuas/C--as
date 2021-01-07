using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write("{0} ", i);
                }
            }

        }
    }
}
