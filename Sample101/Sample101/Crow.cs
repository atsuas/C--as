using System;


namespace Sample101
{
    class Crow : Bird
    {
        public Crow() : base("カラス")
        {
        }
        //カラスが鳴く
        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }
    }
}
