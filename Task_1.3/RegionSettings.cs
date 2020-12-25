using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._3
{
    public class RegionSettings
    {
        public string Website { get; }

        public RegionSettings(string website)
        {
            Website = website;
        }

        public override string ToString()
        {
            return " " + Website;
        }
    }
}
