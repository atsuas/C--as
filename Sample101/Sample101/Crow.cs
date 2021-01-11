using System;


namespace Sample101
{
    //  カラスクラス
    class Crow
    {
        private String name = "カラス";
        //カラスがなく
        public void Sing()
        {
            Console.WriteLine("カーカー");
        }
        //名前を取得
        public String Name
        {
            get { return name; }
        }
    }
}
