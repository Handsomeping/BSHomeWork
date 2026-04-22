namespace HW1_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入的年份
            int year = int.Parse(textBox1.Text);
            // 民國轉換西元差距
            int transYear = 1911;
            // 判斷是否閏年，閏年366天，平年365天
            int totalDays = DateTime.IsLeapYear(year + transYear) ? 366 : 365;
            // 判斷有幾個完整一週，就代表至少有幾個星期六與星期日
            int baseCount = totalDays / 7;   // 一定是 52
            // 剩下來幾天
            int extraDays = totalDays % 7;   // 1 或 2
            // 設定基礎天數
            int saturdayCount = baseCount;
            int sundayCount = baseCount;
            // DateTime 設定為1月1日
            DateTime firstDay = new DateTime(year, 1, 1);

            // 計算多餘的天數，若為星期六日，則對應變數+1
            for (int i = 0; i < extraDays; i++)
            {
                DayOfWeek day = firstDay.AddDays(i).DayOfWeek;

                if (day == DayOfWeek.Saturday)
                {
                    saturdayCount++;
                }
                else if (day == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }

            // 將計算出的數字加上去
            label1.Text = "星期六:" + saturdayCount;
            label2.Text = "星期日:" + sundayCount;
        }
    }
}
