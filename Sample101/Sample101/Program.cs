using System;
using System.Collections.Generic;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            //ハッシュセットの生成
            HashSet<int> t = new HashSet<int>();
            //データの追加
            t.Add(1);
            t.Add(2);
            t.Add(3);
            t.Add(1);   //被っているので出力されない
            //データの出力
            foreach (int i in t)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
