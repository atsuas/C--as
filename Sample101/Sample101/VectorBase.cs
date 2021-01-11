using System;


namespace Sample101
{
    //スーパークラス(抽象プロパティ持つ)
    abstract class VectorBase
    {
        //抽象プロパティ
        public abstract double X
        {
            set;
            get;
        }
        public abstract double Y
        {
            set;
            get;
        }
    }
}
