namespace prob3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力:");
            string inputStr = Console.ReadLine();

            if (inputStr == "abc")
            {
                Console.WriteLine("abcです。");
            }
            else
            {
                Console.WriteLine("abcではありません。");
            }
        }
    }
}