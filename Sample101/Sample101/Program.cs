using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            Crow c = new Crow();        //カラスクラス
            Sparrow s = new Sparrow();  //スズメクラス
            //カラスがなく
            Console.Write(c.Name + " : ");
            c.Sing();
            //スズメがなく
            Console.Write(s.Name + " : ");
            s.Sing();
        }
    }
}
