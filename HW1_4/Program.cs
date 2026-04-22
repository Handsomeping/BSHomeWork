namespace HW1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入層數(1~9):");
            string input = Console.ReadLine();
            int layer = Convert.ToInt32(input);

            for (int i = layer; i > 0; i--)
            {
                // layer - i + 1 個數字
                int digit = layer - i + 1;
                while (digit > 0)
                {
                    Console.Write(i);
                    digit--;
                }

                // i - 1 個空格(可以沒有這段，小黑窗看起來一樣)
                int space = i - 1;
                while (space > 0)
                {
                    Console.Write(" ");
                    space--;
                }

                
                Console.WriteLine();
            }
        }
    }
}
