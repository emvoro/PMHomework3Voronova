using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._2.Comparers
{
    public class NameComparer : IComparer<Player>
    {
        public int Compare(Player firstPlayer, Player secondPlayer)
        {
            string firstPlayerName = string.Join(' ', new string[] { firstPlayer.FirstName, firstPlayer.LastName });
            string secondPlayerName = string.Join(' ', new string[] { secondPlayer.FirstName, secondPlayer.LastName });
            return firstPlayerName.CompareTo(secondPlayerName);
        } 
    }
}
