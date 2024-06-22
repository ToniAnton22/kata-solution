using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void foo()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 4, Quality = 9 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal("fixme", Items[0].Name);
    }
}