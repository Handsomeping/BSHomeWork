namespace HW1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入中華民國年，判斷是否閏年");
            string chineseYearStr = Console.ReadLine();
            int chineseYear = Convert.ToInt32(chineseYearStr);
            int transYear = 1911;
            int year = chineseYear + transYear;

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("閏年");
            }
            else 
            {
                Console.WriteLine("不是閏年");
            }
        }
    }
}
