using System;


namespace Sample101
{

    //電子メール
    interface IEmail
    {
        //メールを送る
        void SendMail(string address);
    }
}
