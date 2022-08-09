namespace prob3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("整数値を入力:");

#pragma warning disable CS8604 // Null 参照引数の可能性があります。
            int a = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Null 参照引数の可能性があります。


            if (a == 3)
            {
                Console.WriteLine("3です");
            }
        }
    }
}