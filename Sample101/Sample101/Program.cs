using System;
using System.Collections.Generic;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> a = new List<String>();
            //データを追加
            a.Add("taro");
            a.Add("hanako");
            a.Add("jiro");
            a.Add("kaoru");
            //データを削除
            a.Remove("taro");   //"taro"を削除
            a.RemoveAt(1);      //１番目のデータを削除
            foreach (String s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
