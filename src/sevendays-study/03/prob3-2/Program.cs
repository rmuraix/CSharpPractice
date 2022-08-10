using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int num = int.Parse(Console.ReadLine());

            if (num != 4)
            {
                Console.WriteLine("4ではありません");
            }

        }
    }
}