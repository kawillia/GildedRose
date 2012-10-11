using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRose.Core.Strategies.Quality;
using GildedRose.Core.Items;

namespace GildedRose.UnitTests.Strategies.Quality
{
    [TestClass]
    public class BackstagePassQualityStrategyTests
    {
        private BackstagePassQualityStrategy strategy;

        public BackstagePassQualityStrategyTests()
        {
            strategy = new BackstagePassQualityStrategy();
        }

        [TestMethod]
        public void QualityDoesNotGoAboveFiftyWhenSellInIsGreaterThanTenDays()
        {
            var item = new Item();
            item.Quality = 50;
            item.SellIn = 11;

            strategy.UpdateQuality(item);

            Assert.AreEqual(50, item.Quality);
        }

        [TestMethod]
        public void QualityIncreasesByOneWhenSellInIsGreaterThanTenDays()
        {
            var item = new Item();
            item.Quality = 49;
            item.SellIn = 11;

            strategy.UpdateQuality(item);

            Assert.AreEqual(50, item.Quality);
        }

        [TestMethod]
        public void QualityDoesNotGoAboveFiftyWhenSellInIsWithinSixAndTenDays()
        {
            var item = new Item();
            item.Quality = 49;
            item.SellIn = 6;

            strategy.UpdateQuality(item);

            Assert.AreEqual(50, item.Quality);
        }

        [TestMethod]
        public void QualityIncreasesByTwoWhenSellInIsWithinSixAndTenDays()
        {
            var item = new Item();
            item.Quality = 47;
            item.SellIn = 6;

            strategy.UpdateQuality(item);

            Assert.AreEqual(49, item.Quality);
        }

        [TestMethod]
        public void QualityDoesNotGoAboveFiftyWhenSellInIsWithinZeroAndFiveDays()
        {
            var item = new Item();
            item.Quality = 49;
            item.SellIn = 5;

            strategy.UpdateQuality(item);

            Assert.AreEqual(50, item.Quality);
        }

        [TestMethod]
        public void QualityIncreasesByThreeWhenSellInIsWithinZeroAndFiveDays()
        {
            var item = new Item();
            item.Quality = 47;
            item.SellIn = 5;

            strategy.UpdateQuality(item);

            Assert.AreEqual(50, item.Quality);
        }
    }
}
