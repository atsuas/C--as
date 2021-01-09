using System;


namespace Sample101
{
    public class Vector2D
    {
        public void Add(Vector2D v)
        {
            X += v.X; Y += v.Y;
        }
        public void Sub(Vector2D v)
        {
            X -= v.X; Y -= v.Y;
        }
        public void Mul(double k)
        {
            X *= k; Y *= k;
        }
        public double DotProduct(Vector2D v)
        {
            return X * v.X + Y * v.Y;
        }
        public double X
        {
            set; get;
        }
        public double Y
        {
            set; get;
        }
            
    }
}
