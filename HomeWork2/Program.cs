namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數數字,1~9");

            int num = int.Parse(Console.ReadLine());

            var result = Enumerable.Range(1, num)
                .Select(i => string.Concat(Enumerable.Repeat(num - i + 1, i)));

            var item = string.Join(Environment.NewLine, result);

            Console.WriteLine(item);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //_____________________________________________________


            
        }
    }
}
