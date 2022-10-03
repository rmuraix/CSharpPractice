namespace prob3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1から3の値を入力（1:グー 2:パー 3:チョキ):");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("グー");
                    break;
                case 2:
                    Console.WriteLine("チョキ");
                    break;
                case 3:
                    Console.WriteLine("パー");
                    break;
                default:
                    Console.WriteLine("正しい値ではありません");
                    break;
            }
        }
    }
}