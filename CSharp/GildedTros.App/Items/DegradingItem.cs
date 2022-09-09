using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    public class DegradingItem : Item, IHandleQualityUpdate
    {
        private const int MaxQuality = 50;
        protected int qualityDegradationRate;

        public DegradingItem(string name, int sellIn, int quality, int qualityDegradationRate)
        {
            Name = name;
            SellIn = sellIn < 0 ? 0 : sellIn;
            Quality = Math.Clamp(quality, 0, MaxQuality);
            this.qualityDegradationRate = Math.Clamp(qualityDegradationRate, 0, int.MaxValue);
            if (SellIn == 0)
            {
                this.qualityDegradationRate *= 2;
            }
        }

        public void UpdateQuality()
        {
            Quality -= qualityDegradationRate;

            if (Quality < 0)
            {
                Quality = 0;
            }

            if (SellIn > 0)
            {
                SellIn--;

                if (SellIn == 0)
                {
                    qualityDegradationRate *= 2;
                }
            }
        }
    }
}