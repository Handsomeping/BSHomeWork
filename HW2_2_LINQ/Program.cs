namespace HW2_2_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入層數(1~9):");
            string input = Console.ReadLine();
            int layer = Convert.ToInt32(input);

            // Enumerable.Range 從數字1做到layer 類似迴圈   
            var result = Enumerable.Range(1, layer)
            .Select
            // string.Concat(IEnumerable)將組合起來
            // Enumerable.Repeat(a,b) 重複a這個字b次
            (i => string.Concat(Enumerable.Repeat((layer - i + 1).ToString(), i)));

            //var result = Enumerable.Range(1, layer)
            //.Select
            //(
            //    i => string.Concat
            //    (
            //        Enumerable.Repeat
            //        (
            //            (layer - i + 1).ToString(), i
            //        )
            //    )
            //);

            // 顯示
            foreach (var line in result)
            {
                Console.WriteLine(line);
            }
        }
    }
}
