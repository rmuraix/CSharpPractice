namespace prob2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? str1, str2;

            Console.Write("文字列1を入力:");
            str1 = Console.ReadLine();
            Console.Write("文字列2を入力:");
            str2 = Console.ReadLine();
            Console.WriteLine("文字列１＋文字列２＝{0}", str1 + str2);
        }
    }
}