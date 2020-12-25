using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._2.Comparers
{
    public class PlayersEqualityComparer : IEqualityComparer<Player>
    {
        public bool Equals(Player firstPlayer, Player secondPlayer)
        {
            return firstPlayer.FirstName.Equals(secondPlayer.FirstName)
                && firstPlayer.LastName.Equals(secondPlayer.LastName)
                && firstPlayer.Age == secondPlayer.Age 
                && firstPlayer.Rank == secondPlayer.Rank;
        }

        public int GetHashCode(Player player)
        {
            return player.FirstName.GetHashCode() ^ player.LastName.GetHashCode() ^ player.Age.GetHashCode() ^ (int)player.Rank.GetHashCode();
        }
    }
}
