using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._2.Comparers
{
    public class RankComparer : IComparer<Player>
    {
        public int Compare(Player firstPlayer, Player secondPlayer)
        {
            return firstPlayer.Rank.CompareTo(secondPlayer.Rank);
        }
    }
}
