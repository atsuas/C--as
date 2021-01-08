using System;


namespace Sample101
{
    public class Vecter2D
    {
        public double x, y;
        public void Add(Vecter2D v)
        {
            x += v. x;
            y += v. y;
        }
        public void Sub(Vecter2D v)
        {
            x -= v.x;
            y -= v.y;
        }
        public void Mul(double k)
        {
            x *= k;
            y *= k;
        }
        public double DotProduct(Vecter2D v)
        {
            return x * v.x + y * v.y;
        }
    }
}
