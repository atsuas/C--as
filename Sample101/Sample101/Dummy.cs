using System;


namespace Sample101
{
    class Dummy
    {
        //コンストラクタ
        public Dummy()
        {
            Console.WriteLine("コンストラクタ");
        }
        //デストラクタ
        ~Dummy()
        {
            Console.WriteLine("デストラクタ");
        }
    }
}
