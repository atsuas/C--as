using System;


namespace Sample101
{
    //Calculatorクラスを継承した、ExCalculatorクラス
    class ExCalculator : Calculator
    {
        //掛け算
        public void mul ()
        {
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }
        //割り算
        public void div ()
        {
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        }
    }
}
