namespace prob3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数の値をを入力してください:");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("負の値です");
            }
            else if (num == 0)
            {
                Console.WriteLine("0です");
            }
            else
            {
                Console.WriteLine("正の値です");
            }
        }
    }
}