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
        public static Item CreateAppreciatingItem(string name, uint sellIn, uint quality, uint appreciationRate)
        {
            return null;
        }

        public static Item CreateDegradingItem(string name, uint sellIn, uint quality, uint degradationRate)
        {
            return null;
        }

        public static Item CreateLegendaryItem(string name, uint sellIn, uint quality)
        {
            return null;
        }
    }
}