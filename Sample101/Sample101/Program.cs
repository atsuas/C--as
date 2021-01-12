using System;
using System.Collections.Generic;   //コレクションを使う際に記述する
using System.Text;
using System.Linq;                  //Max、Minを表示する際に記述が必要
using System.Threading.Tasks;

namespace Sample101
{
    //Programクラス
    class Program
    {   //デリゲートの宣言
        delegate void Action(int a);
        // １つ目の処理
        static void Func1(int a)
        {
            Console.WriteLine("a={0}", a);
        }
        // 2つ目の処理
        static void Func2(int a)
        {
            Console.WriteLine("a*2={0}", a * 2);
        }
        // 3つ目の処理
        static void Func3(int a)
        {
            Console.WriteLine("a*3={0}", a * 3);
        }

        static void Main(string[] args)
        {

            Action a = new Action(Func1);
            //処理の追加
            a += new Action(Func2);
            a += new Action(Func3);
            //処理の実行
            a(3);
        }
    }
}
