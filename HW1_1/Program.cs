namespace HW1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            if (num % 2 == 0)
            {
                Console.WriteLine("偶數");
            }
            else
            {
                Console.WriteLine("奇數");
            }
        }
    }
}
