using System;
using System.Linq;

namespace Task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task 1.1 LINQ Array Statistics\n Voronova Emilia" +
                "\n Enter an array using coma in between of elements. If input is correct you'll get the statistics for your array");
            var stringArray = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            while (!stringArray.Any() || stringArray.Any(x => !int.TryParse(x, out _)))
            {
                Console.WriteLine("You have entered invalid array elements. Try again!");
                stringArray = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            }
            var integerArray = stringArray.Select(int.Parse).ToArray();
            Console.WriteLine($" Minimal element     : {integerArray.Min()}" +
                $"\n Maximal element     : {integerArray.Max()}" +
                $"\n Array sum           : {integerArray.Sum()}" +
                $"\n Array average       : {integerArray.Average()}" +
                $"\n Standard deviation  : " +
                $"{Math.Sqrt(integerArray.Select(x => (x - integerArray.Average()) * (x - integerArray.Average())).Sum() / integerArray.Length)}" +
                $"\n Sorted unique array : {string.Join(' ', integerArray.Distinct().OrderBy(x => x))}");
        }
    }
}
