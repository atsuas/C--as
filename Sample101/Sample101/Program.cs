using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            num = 1;
            // whileループで実行
            Console.Write("whileで実行:");
            i = 1;
            while (i < num)
            {
                Console.Write("*");
                i++;
            }
            Console.WriteLine();
            // do~ehileループで実行
            Console.Write("do~ehileで実行:");
            do
            {
                Console.WriteLine("*");
                i++;
            } while (i < num);
        }
    }
}
