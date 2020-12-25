using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task_1._2.Comparers
{
    public class AgeComparer : IComparer<Player>
    {
        public int Compare(Player firstPlayer, Player secondPlayer)
        {
            return firstPlayer.Age.CompareTo(secondPlayer.Age);
        }
    }
}
