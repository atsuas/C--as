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
            string[] months = { "January", "February", "March","April", "May",
                        "June", "July", "August", "September", "October", "November", "December"};
            Dictionary<string, int> m = new Dictionary<string, int>();
            //月の名前と番号を対応
            for(int i = 0; i < months.Length; i++)
            {
                m[months[i]] = i + 1;
            }
            //月の名前を入力
            Console.Write("英語で月の名前を入力してください:");
            string name = Console.ReadLine();
            //結果の表示
            Console.WriteLine("{0}は{1}月です ", name, m[name]);
        }
    }
}
