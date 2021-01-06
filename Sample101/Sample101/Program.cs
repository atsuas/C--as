using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            //サイコロの目を入力
            Console.Write("サイコロの目(1~6):");
            //コンソールから数値を入力
            int dice = int.Parse(Console.ReadLine());

            //値が、サイコロの目の範囲内かどうかを調べる
            if (1 <= dice && dice <= 6)
            {
                //サイコロの目が、偶数か奇数かで処理を分ける
                if (dice == 2 || dice == 4 || dice == 6)
                {
                    Console.WriteLine("丁です！"); //偶数ならば丁
                }
                else
                {
                    Console.WriteLine("半です！");  //奇数ならば半
                }
            }
            else
            {
                Console.WriteLine("範囲外の数値です");
            }
        }
    }
}
