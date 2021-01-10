using System;

namespace Sample101
{
    class Program
    {
        //ベクトルの内容を表示するメソッド
        static void Show(string name, Vector2D v)
        {
            Console.WriteLine("{0}=({1}, {2})", name,v.X, v.Y);
        }

        static void Main(string[] args)
        {
            
            Vector2D v1 = new Vector2D(1.0, 1.0);
            Show("v1", v1);     //  v1=(1,1)と表示
            Vector2D w = new Vector2D(1.0, -1.0);

            Vector2D v2 = new Vector2D(w);
            Show("v2", v2);     //  v2=(1,-1)と表示

            v1.Add(v2);
            Show("v1", v1);

            v1.Sub(v2);
            Show("v1", v1);

            v1.Mul(2.0);
            Show("v1", v1);

            Console.WriteLine("v1, v2の内積:{0}", v1.DotProduct(v2));

        }
    }
}
