using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    /// <summary>
    /// Handles the creation of the different types of possible items, this to handle the separation of the different possible behaviours in the derived classes
    /// </summary>
    public static class ItemFactory
    {
        private const string backstagePassTag = "Backstage passes";

        private static readonly HashSet<string> legendaryItems = new HashSet<string>
        {
            "B-DAWG Keychain"
        };

        private static readonly HashSet<string> appreciatingItems = new HashSet<string>
        {
            "Good Wine"
        };

        private static readonly HashSet<string> smellyItems = new HashSet<string>
        {
            "Duplicate Code",
            "Long Methods",
            "Ugly Variable Names"
        };

        public static Item CreateItem(string name, int sellIn, int quality)
        {
            if (name.Contains(backstagePassTag))
            {
                return new BackstagePassItem(name, sellIn, quality);
            }
            else if (legendaryItems.Contains(name))
            {
                return new LegendaryItem(name);
            }
            else if (appreciatingItems.Contains(name))
            {
                return new AppreciatingItem(name, sellIn, quality);
            }
            else if (smellyItems.Contains(name))
            {
                return new DegradingItem(name, sellIn, quality, 2);
            }
            else
            {
                return new DegradingItem(name, sellIn, quality, 1);
            }
        }
    }
}