using System;


namespace Sample101
{
    //  子クラス
    class Child : Parent
    {
        public override void Foo()
        {
            Console.WriteLine("小クラスのFoo()メソッド");
        }
    }
}
