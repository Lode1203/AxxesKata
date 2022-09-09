using GildedTros.App.Items;
using System.Collections.Generic;

namespace GildedTros.App
{
    public class GildedTros
    {
        private IList<Item> Items;

        public GildedTros(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                (item as IHandleQualityUpdate)?.UpdateQuality();
            }
        }
    }
}