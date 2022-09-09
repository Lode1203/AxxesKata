using GildedTros.App.Items;
using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class GildedTrosTest
    {
        [Theory]
        [InlineData("degradingItem", 0, 0, 0, 0, typeof(DegradingItem))]
        [InlineData("degradingItem", 10, 60, 9, 49, typeof(DegradingItem))]
        [InlineData("B-DAWG Keychain", 0, 0, 0, 80, typeof(LegendaryItem))]
        [InlineData("B-DAWG Keychain", 10, 60, 0, 80, typeof(LegendaryItem))]
        [InlineData("Backstage passes: testConcert", 0, 0, 0, 0, typeof(BackstagePassItem))]
        [InlineData("Backstage passes: testConcert", 10, 0, 9, 2, typeof(BackstagePassItem))]
        [InlineData("Backstage passes: testConcert", 5, 0, 4, 3, typeof(BackstagePassItem))]
        [InlineData("Backstage passes: testConcert", 1, 50, 0, 0, typeof(BackstagePassItem))]
        [InlineData("Good Wine", 0, 0, 0, 1, typeof(AppreciatingItem))]
        [InlineData("Good Wine", 10, 60, 9, 50, typeof(AppreciatingItem))]
        [InlineData("Duplicate Code", 0, 4, 0, 0, typeof(DegradingItem))]
        [InlineData("Long Methods", 0, 4, 0, 0, typeof(DegradingItem))]
        [InlineData("Ugly Variable Names", 0, 4, 0, 0, typeof(DegradingItem))]
        [InlineData("Duplicate Code", 1, 2, 0, 0, typeof(DegradingItem))]
        [InlineData("Long Methods", 1, 2, 0, 0, typeof(DegradingItem))]
        [InlineData("Ugly Variable Names", 1, 2, 0, 0, typeof(DegradingItem))]
        public void CreateSingleItem_SingleUpdate(string name, int sellIn, int quality, int expectedSellIn, int expectedQuality, System.Type expectedType)
        {
            IList<Item> Items = new List<Item>
            {
                ItemFactory.CreateItem(name, sellIn, quality)
            };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(name, Items[0].Name);
            Assert.Equal(expectedSellIn, Items[0].SellIn);
            Assert.Equal(expectedQuality, Items[0].Quality);
            Assert.Equal(expectedType, Items[0].GetType());
        }
    }
}