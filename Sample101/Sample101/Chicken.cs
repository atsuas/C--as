using System;
namespace Sample101
{
    class Chicken : Bird
    {
        public Chicken() : base ("にわとり")
        {
        }

        public override void Sing()
        {
            Console.WriteLine("コケコッコー");
        }
    }
}
