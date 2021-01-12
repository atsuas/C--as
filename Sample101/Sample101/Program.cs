using System;
using System.Collections.Generic;   //コレクションを使う際に記述する
using System.Text;
using System.Linq;                  //Max、Minを表示する際に記述が必要
using System.Threading.Tasks;

namespace Sample101
{
    //デリゲート
    delegate void Operation(int a, int b);
    //Calcクラス
    class Calc
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
    }
    //Programクラス
    class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        static void Main(string[] args)
        {
            Calc c = new Calc();
            //デリゲートの設定
            Operation o1 = new Operation(Add);
            Operation o2 = new Operation(c.Sub);
            //デリゲートで設定したメソッドの呼び出し
            o1(2, 1);
            o2(2, 1);
        }
    }
}
