namespace HW1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數");
            string input = Console.ReadLine();
            string[] strArray = input.Split(',');
            string[] reversrStrArray = new string[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                reversrStrArray[i] = strArray[strArray.Length - 1 - i];
            }

            Console.WriteLine(String.Join(",", reversrStrArray));
        }
    }
}
