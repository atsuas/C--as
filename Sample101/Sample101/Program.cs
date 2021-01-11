using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data();
            IWrite wr = d;
            IRead rd = d;
            wr.Write(1);     //データの書き込み
            int num = rd.Read();
            Console.WriteLine("data={0}", num);
        }
    }
}
