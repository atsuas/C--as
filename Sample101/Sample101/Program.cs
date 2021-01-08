using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;
            p1 = new Person();  //１つ目のPersonクラスのメソッドのインスタンスを生成
            p1.name = "山田太郎";   //フィールドnameに値を代入
            p1.age = 19;           //フィールドageに値を代入
            //ShowAgeAndName()メソッドで、それぞれのインスタンスのnameとageを表示
            p1.ShowAgeAndName();
        }
    }
}
