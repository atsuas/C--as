﻿using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            //追加部分 ↓
            Vector2D v1 = new Vector2D(1.0, 1.0);
            Console.WriteLine("v1=({0}, {1})", v1.X, v1.Y);
            Vector2D w = new Vector2D(1.0, -1.0);
            Vector2D v2 = new Vector2D(w);
            //追加部分 ↑

            Console.WriteLine("v2=({0}, {1})", v2.X, v2.Y);

            v1.Add(v2);
            Console.WriteLine("v1=({0}, {1})", v1.X, v1.Y);

            v1.Sub(v2);
            Console.WriteLine("v1=({0}, {1})", v1.X, v1.Y);

            v1.Mul(2.0);
            Console.WriteLine("v1=({0}, {1})", v1.X, v1.Y);

            Console.WriteLine("v1, v2の内積:{0}", v1.DotProduct(v2));

        }
    }
}
