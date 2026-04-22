namespace HW1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數");
            string input = Console.ReadLine();
            string[] numberStrArray = input.Split(',');
            int[] numberArray = new int[numberStrArray.Length];
            int evenNumberCount = 0;

            // 計算奇偶數陣列分別需要多少空間
            for (int i = 0; i < numberStrArray.Length; i++)
            {
                numberArray[i] = int.Parse(numberStrArray[i]);
                if (numberArray[i] % 2 == 0)
                {
                    evenNumberCount++;
                }
            }

            // 分別存入奇偶數陣列
            int[] oddNumberArray = new int[numberStrArray.Length - evenNumberCount];
            int[] evenNumberArray = new int[evenNumberCount];
            int oddIndex = 0;
            int evenIndex = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 2 == 0)
                {
                    evenNumberArray[evenIndex] = numberArray[i];
                    evenIndex++;
                }
                else
                {
                    oddNumberArray[oddIndex] = numberArray[i];
                    oddIndex++;
                }
            }

            // 排序
            bubbleSort(oddNumberArray);
            bubbleSort(evenNumberArray);

            // 組合
            String oddResult = String.Join(",", oddNumberArray);
            String evenResult = String.Join(",", evenNumberArray);

            // 顯示
            Console.WriteLine("奇數:" + oddResult);
            Console.WriteLine("偶數:" + evenResult);
        }

        static void bubbleSort(int[] numberArray)
        {
            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < numberArray.Length - 1 - i; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        int temp = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped) 
                {
                    break;
                }
            }
        }
    }
}
