using System;
using System.Collections.Generic;   //コレクションを使う際に記述する
using System.Text;
using System.Linq;                  //Max、Minを表示する際に記述が必要
using System.Threading.Tasks;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            while (true)
            {
                Console.Write("1~10の整数を入力:");
                int num = int.Parse(Console.ReadLine());
                if(num < 1 || num > 10)
                {
                    break;  //範囲外であればループから抜ける
                }
                l.Add(num);
            }

            foreach(int n in l)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();
            //　最大値・最小値の表示
            Console.WriteLine("最大値{0} 最小値{1}", l.Max(), l.Min());
        }
    }
}
