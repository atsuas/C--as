using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D v1 = new Vector2D();
            v1.X = 1.0; v1.Y = 1.0;
            Console.WriteLine("v1=({0}, {1})", v1.X, v1.Y); //  v1=（1,1）と表示される

            Vector2D v2 = new Vector2D();
            v2.X = 1.0; v2.Y = -1.0;
            Console.WriteLine("v2=({0}, {1})", v2.X, v2.Y);   //  v2= (1,-1) と表示される

            //v1+v2
            v1.Add(v2);
            Console.WriteLine("v1=({0}, {1})", v1.X, v1.Y); //  v1=（2,0）と表示される

            //v1-v2
            v1.Sub(v2);
            Console.WriteLine("v1=({0}, {1})", v1.X, v1.Y); //  v1=（1,1）と表示される

            //2*v1
            v1.Mul(2.0);
            Console.WriteLine("v1=({0}, {1})", v1.X, v1.Y); //  v1=（2,2）と表示される

            //v1.v2の内積
            Console.WriteLine("v1, v2の内積: {0}", v1.DotProduct(v2)); //v1.v1の内積は０と出る

        }
    }
}
