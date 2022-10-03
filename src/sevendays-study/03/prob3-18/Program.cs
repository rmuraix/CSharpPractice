namespace prob3_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("温度を入力してください(-10～35):");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine("摂氏" + temp + "度");
            switch (temp)
            {
                case > 35 or < -10:
                    Console.WriteLine("適切な値を入力してください。");
                    break;
                case >= 30:
                    Console.WriteLine("真夏日です。");
                    break;
                case >= 25:
                    Console.WriteLine("夏日です。");
                    break;
                case < 0:
                    Console.WriteLine("真冬日です。");
                    break;
                default:
                    Console.WriteLine("規定されていません。"); // Behavior not in question
                    break;
            }
        }
    }
}