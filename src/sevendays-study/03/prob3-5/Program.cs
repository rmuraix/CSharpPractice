namespace prob3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int num = int.Parse(Console.ReadLine());

            if (num > 30 || num <= 70)
            {
                Console.WriteLine("30より大きく70以下です");
            }
        }
    }
}