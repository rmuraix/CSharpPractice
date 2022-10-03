namespace prob3_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(num % 3 == 0 ? "2と3の公倍数です" : "2の倍数です");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("3の倍数です");
            }
        }
    }
}