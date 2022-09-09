using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    public class BackstagePassItem : Item, IHandleQualityUpdate
    {
        private const int MaxQuality = 50;
        private const int DefaultRate = -1;
        private const int TenDaysOrlessRate = 2;
        private const int FiveDaysOrLessRate = 3;
        private const int ExpiredRate = 0;

        public BackstagePassItem(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn < 0 ? 0 : sellIn;
            Quality = Math.Clamp(quality, 0, MaxQuality);
        }

        public void UpdateQuality()
        {
            int qualityRate = GetQualityUpdateRate();
            Quality += qualityRate;

            if (Quality <= 0)
            {
                Quality = 0;
            }
            else if (Quality > MaxQuality)
            {
                Quality = MaxQuality;
            }

            if (SellIn > 0)
            {
                SellIn--;
                if (SellIn == 0)
                {
                    Quality = 0;
                }
            }
        }

        private bool IsExpired()
        {
            if (SellIn <= 0)
            {
                return true;
            }
            return false;
        }

        private bool IsFiveDaysOrLess()
        {
            if (SellIn <= 5)
            {
                return true;
            }
            return false;
        }

        private bool IsTenDaysOrLess()
        {
            if (SellIn <= 10)
            {
                return true;
            }
            return false;
        }

        private int GetQualityUpdateRate()
        {
            if (IsExpired())
            {
                return ExpiredRate;
            }
            else if (IsFiveDaysOrLess())
            {
                return FiveDaysOrLessRate;
            }
            else if (IsTenDaysOrLess())
            {
                return TenDaysOrlessRate;
            }
            else
            {
                return DefaultRate;
            }
        }
    }
}