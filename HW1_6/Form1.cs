

using System.Reflection.Emit;

namespace HW1_6
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

            // 計算星期六、日的變數
            int saturdayCount = 0;
            int sundayCount = 0;

            // DateTime 設定為1月1日
            DateTime dt = new DateTime(year, 1, 1);

            // 當dt的年份與使用者輸入的相同，則繼續
            while (dt.Year == year)
            {
                // 當dt是星期六或星期日，對應變數+1
                if (dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
                else if (dt.DayOfWeek == DayOfWeek.Saturday)
                {
                    saturdayCount++;
                }
                // 將dt加一天
                dt = dt.AddDays(1);
            }

            // 將計算出的數字加上去
            label1.Text = "星期六:" + saturdayCount;
            label2.Text = "星期日:" + sundayCount;
        }
    }
}
