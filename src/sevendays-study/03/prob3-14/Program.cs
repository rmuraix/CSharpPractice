using System;

namespace prob3_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a,bに1から10までの数値を入力してください。");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            if (a is < 1 or > 10 || b is < 1 or > 10) // 範囲外
            {
                Console.WriteLine("範囲外です");
            }
            else if (a > b)
            {
                Console.WriteLine("aの方が大きいです");
            }
            else if (a == b)
            {
                Console.WriteLine("等しいです");
            }
            else
            {
                Console.WriteLine("bの方が大きいです");
            }
        }
    }
}