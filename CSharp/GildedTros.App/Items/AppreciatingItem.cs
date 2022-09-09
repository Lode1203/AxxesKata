using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    public class AppreciatingItem : Item, IHandleQualityUpdate
    {
        private const int MaxQuality = 50;
        protected int qualityAppreciationRate;

        public AppreciatingItem(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn < 0 ? 0 : sellIn;
            Quality = Math.Clamp(quality, 0, MaxQuality);
            qualityAppreciationRate = 1;
        }

        public void UpdateQuality()
        {
            Quality += qualityAppreciationRate;

            if (Quality > MaxQuality)
            {
                Quality = MaxQuality;
            }

            if (SellIn > 0)
            {
                SellIn--;
            }
        }
    }
}