﻿using System;
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
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    int a = 5;  //getNum(i);
                    int b = 0;  //5;
                    Console.Write(a + " / " + b + " = ");
                    Console.WriteLine(calc(a, b));
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine();
                Console.WriteLine("0による割り算発生");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("配列の範囲外にアクセスしました");
            }
            finally
            {
                Console.WriteLine("終了");
            }
        }
        //計算処理(例外を発生させる)
        private static int calc(int a, int b)
        {
            return a / b;
        }
        //範囲外に出たときの処理
        public static int getNum(int index)
        {
            int[] num = { 1, 2, 3, 4 };
            return num[index];
        }
    }
}
