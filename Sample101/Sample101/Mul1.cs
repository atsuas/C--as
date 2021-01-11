using System;
namespace Sample101
{
    class Mul1 : IMul
    {
        public int Calc(int a, int b)
        {
            int result = 0;
            for(int i = 0; i < b; i++)
            {
                result += a;
            }
            return result;
        }
    }
}
