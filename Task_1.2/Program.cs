using System;
using System.Collections.Generic;
using System.Linq;
using Task_1._2.Comparers;

namespace Task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task 1.2 Three sortings and one comparator\n Voronova Emilia");
            List<Player> players = new List<Player>()
            {
                new Player(29, "Ivan", "Ivanenko", PlayerRank.Captain),
                new Player(19, "Peter", "Petrenko", PlayerRank.Private),
                new Player(59, "Ivan", "Ivanov", PlayerRank.General),
                new Player(52, "Ivan", "Snezko", PlayerRank.Lieutenant),
                new Player(34, "Alex", "Zeshko", PlayerRank.Colonel),
                new Player(29, "Ivan", "Ivanenko", PlayerRank.Captain),
                new Player(19, "Peter", "Petrenko", PlayerRank.Private),
                new Player(34, "Vasiliy", "Sokol", PlayerRank.Major),
                new Player(31, "Alex", "Alexeenko", PlayerRank.Major)
            };

            players = players.Distinct(new PlayersEqualityComparer()).ToList();

            Console.WriteLine("\n Sorted by rank : \n");
            players.Sort(new RankComparer());
            players.ForEach(x => x.PrintPlayer());

            Console.WriteLine("\n Sorted by name : \n");
            players.Sort(new NameComparer());
            players.ForEach(x => x.PrintPlayer());

            Console.WriteLine("\n Sorted by age : \n");
            players.Sort(new AgeComparer());
            players.ForEach(x => x.PrintPlayer());
        }
    }
}
