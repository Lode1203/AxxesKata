using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    public class LegendaryItem : Item
    {
        private const int LegendaryQuality = 80;

        public LegendaryItem(string name)
        {
            Name = name;
            Quality = LegendaryQuality;
            SellIn = 0;
        }
    }
}