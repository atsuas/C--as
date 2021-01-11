using System;


namespace Sample101
{
    // スズメクラス
    class Sparrow
    {
        private String name = "すずめ";
        //スズメがなく
        public void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
        //名前を取得
        public String Name
        {
            get { return name; }
        }
    }
}
