using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] d = new double[3];
            d[0] = 0.2;
            d[1] = 1.4;
            d[2] = -0.8;
            // double[] d = { 0.2, 1.4, -0.8 }; と書いてもいい

            //配列の要素を表示
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, d[i]);
            }
        }
    }
}
