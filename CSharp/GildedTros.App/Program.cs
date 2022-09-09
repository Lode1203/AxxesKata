using GildedTros.App.Items;
using System;
using System.Collections.Generic;

namespace GildedTros.App
{
    internal class Program
    {
        private const int NumberOfDaysToUpdate = 30;

        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> items = CreateItems();
            UpdateItemsForNumberOfDays(NumberOfDaysToUpdate, items);
        }

        private static IList<Item> CreateItems()
        {
            return new List<Item>{
                ItemFactory.CreateItem("Ring of Cleansening Code", 10, 20),
                ItemFactory.CreateItem("Good Wine", 2, 0),
                ItemFactory.CreateItem("Elixir of the SOLID", 5, 7),
                ItemFactory.CreateItem("B-DAWG Keychain", 0, 80),
                ItemFactory.CreateItem("B-DAWG Keychain", -1, 80),
                ItemFactory.CreateItem("Backstage passes for Re:factor", 15, 20),
                ItemFactory.CreateItem("Backstage passes for Re:factor", 10, 49),
                ItemFactory.CreateItem("Backstage passes for HAXX", 5, 49),
                // these smelly items do not work properly yet
                ItemFactory.CreateItem("Duplicate Code", 3, 6),
                ItemFactory.CreateItem("Long Methods", 3, 6),
                ItemFactory.CreateItem("Ugly Variable Names", 3, 6)
            };
        }

        private static void UpdateItemsForNumberOfDays(int numberOfDays, IList<Item> items)
        {
            var app = new GildedTros(items);
            for (var i = 0; i <= numberOfDays; i++)
            {
                DisplayItemsForCurrentDay(i, items);
                app.UpdateQuality();
            }
        }

        private static void DisplayItemsForCurrentDay(int day, IList<Item> items)
        {
            Console.WriteLine("-------- day " + day + " --------");
            Console.WriteLine("name, sellIn, quality");

            foreach (var item in items)
            {
                item.WriteItemPropertyValues();
            }

            Console.WriteLine(string.Empty);
        }
    }
}