using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1
{
    public class Leftover
    {
        public string ProductId { get; }
        public string Location { get; }
        public int LeftoverAmount { get; }

        public Leftover(string productId, string location, int leftoverAmount)
        {
            ProductId = productId;
            Location = location;
            LeftoverAmount = leftoverAmount;
        }
    }
}
