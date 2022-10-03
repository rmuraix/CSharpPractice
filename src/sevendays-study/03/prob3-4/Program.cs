namespace prob3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int num = int.Parse(Console.ReadLine());

            if (num <= 20 || num >= 50)
            {
                Console.WriteLine("20以下か80以上の値です");
            }
        }
    }
}