using System;
namespace Sample101
{
    class Data : IWrite, IRead
    {
        //データ
        private int num = 0;
        public void Write(int num)
        {
            this.num = num;
        }
        public int Read()
        {
            return num;
        }
    }
}