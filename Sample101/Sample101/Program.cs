using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("サイコロの目(1~6):");
            int dice = int.Parse(Console.ReadLine());

            switch (dice)
            {
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("丁です！");
                    break;
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("半です！");
                    break;
                default:
                    Console.WriteLine("範囲外の値です");
                    break;
            }
        }
    }
}
