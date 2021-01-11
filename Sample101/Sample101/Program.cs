using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone cp = new CellPhone("hoge@email.con", "090-1244-5678");
            //携帯電話クラスで、電話とメールを送る
            cp.Call("011-123-4567");
            cp.SendMail("fuga@email.com");
            //電話インターフェイスでインスタンスにアクセス
            IPhone phone = (IPhone)cp;
            phone.Call("011-987-6543"); //電話をかける
            // phone, SendMail("foo@email.com);     メールの送信メソッドは利用できない
            //メールインターフェースでインスタンスにアクセス
            IEmail mail = (IEmail)cp;
            mail.SendMail("bar@email.com"); //メールを出す
            //mail.Call("011-222-3333");    //mailインターフェースでは、電話の機能を利用できない
        }
    }
}
