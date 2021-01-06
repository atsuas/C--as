using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("tempの数値は:");
            double temp = double.Parse(Console.ReadLine());

            if (temp == 0.0)
            {
                Console.WriteLine("ゼロ");
            }
            else if (0.0 < temp)
            {
                Console.WriteLine("プラス");
            }
            else
            {
                Console.WriteLine("マイナス");
            }
        }
    }
}
