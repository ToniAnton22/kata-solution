﻿using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void Foo()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 4, Quality = 20 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal("Conjured Mana Cake", Items[0].Name);
    }
}