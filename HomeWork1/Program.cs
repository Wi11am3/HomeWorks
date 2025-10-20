using System.Security.Cryptography.X509Certificates;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的字串");

            string input = Console.ReadLine();

            var numbers = input.Split(',');

            //string[] num = Console.ReadLine().Split(',');

            var revNumbers = numbers.Reverse();

            string result = string.Join(",", revNumbers);

            Console.WriteLine(result);

            //_____________________________________________________
           

        }
    }
}
