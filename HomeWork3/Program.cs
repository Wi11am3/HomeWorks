namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("輸入一串以逗號分隔的字串");

            var input = Console.ReadLine().Split(',');

            //var odd = input.Select(x => int.Parse(x)).Where(x => x % 2 != 0).OrderBy(x => x);

            var odd = from x in input
                      let num = int.Parse(x)
                      where num % 2 == 0
                      orderby num 
                      select num;


            var even = input.Select(x => int.Parse(x)).Where(x => x % 2 == 0).OrderBy(x => x);

            Console.WriteLine("奇數 :" + string.Join(',', odd));

            Console.WriteLine("偶數 :" + string.Join(',', even));
            //_____________________________________________________
        }
    }
}
