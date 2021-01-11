using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMul m = new Mul1();
            IMul m = new Mul2();
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", a, b, m.Calc(a, b));
        }
    }
}
