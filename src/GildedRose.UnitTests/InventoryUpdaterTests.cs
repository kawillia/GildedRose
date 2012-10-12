using System;
using GildedRose.Core;
using GildedRose.Core.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests
{
    [TestClass]
    public class InventoryUpdaterTests
    {
        private InventoryUpdater updater;

        [TestMethod]
        public void SellInForNormalItemDecreasesByOne()
        {
            var cake = new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 0 };
            updater = new InventoryUpdater(new[] { cake });
            updater.Update();

            Assert.AreEqual(-1, cake.SellIn);
        }

        [TestMethod]
        public void SellInForAgedBrieDecreasesByOne()
        {
            var brie = new AgedBrie { Name = "Aged Brie", SellIn = 5, Quality = 0 };
            updater = new InventoryUpdater(new[] { brie });
            ProcessMany(10);

            Assert.AreEqual(-5, brie.SellIn);
        }

        [TestMethod]
        public void SellInForBackstagePassDecreasesByOne()
        {
            var backstagePass = new BackstagePass { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 0 };
            updater = new InventoryUpdater(new[] { backstagePass });
            ProcessMany(10);

            Assert.AreEqual(-7, backstagePass.SellIn);
        }

        [TestMethod]
        public void SellInForConjuredDecreasesByOne()
        {
            var conjured = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 0, Quality = 0 };
            updater = new InventoryUpdater(new[] { conjured });
            ProcessMany(10);

            Assert.AreEqual(-10, conjured.SellIn);
        }

        [TestMethod]
        public void QualityOfAnItemIsNeverNegative()
        {
            var cake = new Item { Name = "Conjured Mana Cake", SellIn = -1, Quality = 0 };
            updater = new InventoryUpdater(new[] { cake });
            updater.Update();

            Assert.AreEqual(0, cake.Quality);
        }

        [TestMethod]
        public void QualityOfAConjuredItemIsNeverNegative()
        {
            var cake = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = -1, Quality = 0 };
            updater = new InventoryUpdater(new[] { cake });
            updater.Update();

            Assert.AreEqual(0, cake.Quality);
        }

        [TestMethod]
        public void QualityDegradesTwiceAsFastForNormalItem()
        {
            var cake = new Item { Name = "Conjured Mana Cake", SellIn = -1, Quality = 2 };
            updater = new InventoryUpdater(new[] { cake });
            updater.Update();

            Assert.AreEqual(0, cake.Quality);
        }

        [TestMethod]
        public void QualityOfAnItemIsNeverGreaterThanFifty()
        {
            var brie = new AgedBrie { Name = "Aged Brie", SellIn = 0, Quality = 50 };
            updater = new InventoryUpdater(new[] { brie });
            updater.Update();

            Assert.AreEqual(50, brie.Quality);
        }

        [TestMethod]
        public void QualityIncreasesForAgedBrie()
        {
            var brie = new AgedBrie { Name = "Aged Brie", SellIn = 5, Quality = 10 };
            updater = new InventoryUpdater(new[] { brie });
            ProcessMany(10);

            Assert.AreEqual(20, brie.Quality);
        }

        [TestMethod]
        public void SulfurasNeverHasToBeSold()
        {
            var sulfuras = new Sulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 10 };
            updater = new InventoryUpdater(new[] { sulfuras });
            ProcessMany(10);

            Assert.AreEqual(5, sulfuras.SellIn);
        }

        [TestMethod]
        public void SulfurasNeverDegrades()
        {
            var sulfuras = new Sulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 10 };
            updater = new InventoryUpdater(new[] { sulfuras });
            ProcessMany(10);

            Assert.AreEqual(10, sulfuras.Quality);
        }

        [TestMethod]
        public void BackstagePassQualityIncreasesByTwoWhenSellInReachesBetweenSixAndTenDays()
        {
            var backstagePass = new BackstagePass { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 10 };
            updater = new InventoryUpdater(new[] { backstagePass });
            ProcessMany(5);

            Assert.AreEqual(20, backstagePass.Quality);
        }

        [TestMethod]
        public void BackstagePassQualityIncreasesByThreeWhenSellInReachesBetweenFiveAndZeroDays()
        {
            var backstagePass = new BackstagePass { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 10 };
            updater = new InventoryUpdater(new[] { backstagePass });
            ProcessMany(4);

            Assert.AreEqual(22, backstagePass.Quality);
        }

        [TestMethod]
        public void BackstagePassQualityDropsToZeroAfterTheConcert()
        {
            var backstagePass = new BackstagePass { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 };
            updater = new InventoryUpdater(new[] { backstagePass });
            ProcessMany(5);

            Assert.AreEqual(0, backstagePass.Quality);
        }

        [TestMethod]
        public void BackstagePassQualityIncreasesByOneTenDays()
        {
            var backstagePass = new BackstagePass { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 10 };
            updater = new InventoryUpdater(new[] { backstagePass });
            ProcessMany(9);

            Assert.AreEqual(19, backstagePass.Quality);
        }

        [TestMethod]
        public void ConjuredItemsDegradeInQualityTwiceAsFastAsNormalItems()
        {
            var conjuredItem = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };
            updater = new InventoryUpdater(new[] { conjuredItem });
            ProcessMany(3);

            Assert.AreEqual(0, conjuredItem.Quality);
        }

        private void ProcessMany(Int32 numberToProcess)
        {
            for (var i = 0; i < numberToProcess; i++)
                updater.Update();
        }
    }
}