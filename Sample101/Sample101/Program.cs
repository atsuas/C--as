using System;
using System.Collections.Generic;   //コレクションを使う際に記述する
using System.Text;
using System.Linq;                  //Max、Minを表示する際に記述が必要
using System.Threading.Tasks;

namespace Sample101
{
    class Program
    {
        static int GetNum(int i)
        {
            int[] nums = { 300, 600, 900 };
            if(i > nums.Length)
            {
                //例外を発生させる
                throw new IndexOutOfRangeException();
            }
            return nums[i];

        }
        static void Main()
        {
            try
            {
                int result = GetNum(4);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("配列の範囲外にアクセスしました");
            }
        }
    }
}
