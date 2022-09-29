namespace prob3_15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("点数(1-100):");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case > 100 or < 1:
                    Console.WriteLine("範囲外です");
                    break;
                case >= 80:
                    Console.WriteLine("優");
                    break;
                case >= 70:
                    Console.WriteLine("良");
                    break;
                case >= 60:
                    Console.WriteLine("可");
                    break;
                default:
                    Console.WriteLine("不可");
                    break;
            }
        }
    }
}