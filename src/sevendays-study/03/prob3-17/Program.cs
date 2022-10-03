namespace prob3_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力してください(1-100):");
            int num = int.Parse(Console.ReadLine());

            if (num is > 100 or < 1)
            {
                Console.WriteLine("範囲外の値です。");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine(num <= 50 ? "50以下の偶数です。" : "偶数です。");
            }
            else if (num <= 50)
            {
                Console.WriteLine("50以下です。");
            }
        }
    }
}