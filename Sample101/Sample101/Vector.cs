using System;


namespace Sample101
{
    class Sparrow : Bird
    {
        //コンストラクタ
        public Sparrow() : base("すずめ")
        {
        }
        //すずめが鳴く
        public override void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
    }
}
