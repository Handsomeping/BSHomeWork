namespace HW2_3_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數");
            string input = Console.ReadLine();
            var number = input.Split(',').Select(x => int.Parse(x));

            var even = string.Join(',', number
            .Where(x => x % 2 == 0)
            .OrderBy(x => x));
            var odd = string.Join(',', number
            .Where(x => x % 2 != 0)
            .OrderBy(x => x));

            Console.WriteLine($"奇數:{odd}");
            Console.WriteLine($"偶數:{even}");
        }
    }
}
