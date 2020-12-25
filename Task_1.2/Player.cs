using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._2
{
    public class Player : IPlayer
    {
        public int Age { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public PlayerRank Rank { get; }

        public Player(int age, string firstName, string lastName, PlayerRank rank)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Rank = rank;
        }

        public void PrintPlayer()
        {
            Console.WriteLine(" " + Age + ", " +  FirstName + ", " + LastName + ", " + Rank);
        }
    }
}
