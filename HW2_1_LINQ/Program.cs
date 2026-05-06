namespace HW2_1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入逗號分隔的字串");
            Console.WriteLine(String.Join(",", Console.ReadLine().Split(',').Reverse()));
        }
    }
}
