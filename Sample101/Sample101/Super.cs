using System;


namespace Sample101
{
    //スーパークラス
    class Super
    {
        //パラメータ
        private int param = 0;
        //コンストラクタ
        public Super()
        {
            Console.WriteLine("Superクラスのコンストラクタ(引数なし)");
        }
        //コンストラクタ(引数あり)
        public Super(int param)
        {
            Console.WriteLine("Superクラスのコンストラクタ(引数:param={0})", param);
            this.param = param;
        }
        //デストラクタ
        ~Super()
        {
            Console.WriteLine("Superクラスのデストラクタ");
        }
        public void showParam()
        {
            Console.WriteLine("Param = {0}", param);
        }
    }
}
