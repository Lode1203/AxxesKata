using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    public static class ItemExtensions
    {
        public static void WriteItemPropertyValues(this Item item)
        {
            Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
        }
    }
}