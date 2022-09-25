namespace prob_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1から100までの数値を入力してください:");
            var input = Console.ReadLine();
            var num = int.Parse(input);

            if (num < 0 || num > 100)
            {
                Console.WriteLine("範囲外です。");
            }
            else if (num >= 20 && num < 80)
            {
                Console.WriteLine("20以上80未満です。");
            }
            else
            {
                Console.WriteLine("20未満か80以上です。");
            }
        }
    }
}