using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            Access a = new Access();
            a.Data2 = 2;
            a.ShowDatas();
            Console.WriteLine("a.data1 = {0}", a.Data1);
        }
    }
}
