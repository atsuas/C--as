using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parentクラスのインスタンス生成
            Parent p = new Parent();
            //Childクラスのインスタンス生成
            Parent c = new Child();
            //それぞれのクラスのfoo、barメソッドを実行
            p.Foo();
            c.Foo();
        }
    }
}
