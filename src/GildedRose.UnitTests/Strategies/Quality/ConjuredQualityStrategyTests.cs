using GildedRose.Core.Items;
using GildedRose.Core.Strategies.Quality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests.Strategies.Quality
{
    [TestClass]
    public class ConjuredQualityStrategyTests
    {
        private ConjuredQualityStrategy strategy;

        public ConjuredQualityStrategyTests()
        {
            strategy = new ConjuredQualityStrategy(new QualityNeverDegradesBelowZeroStrategy());
        }

        [TestMethod]
        public void QualityDecreasesByTwoWhenSellInIsGreaterThanOrEqualToZero()
        {
            var item = new ConjuredItem();
            item.Quality = 49;
            item.SellIn = 0;

            strategy.UpdateQuality(item);

            Assert.AreEqual(47, item.Quality);
        }

        [TestMethod]
        public void QualityDecreasesByFourWhenSellInIsGreaterThanOrEqualToZero()
        {
            var item = new ConjuredItem();
            item.Quality = 49;
            item.SellIn = -1;

            strategy.UpdateQuality(item);

            Assert.AreEqual(45, item.Quality);
        }

        [TestMethod]
        public void QualityDoesNotGoBelowZero()
        {
            var item = new ConjuredItem();
            item.Quality = 0;
            item.SellIn = -1;

            strategy.UpdateQuality(item);

            Assert.AreEqual(0, item.Quality);
        }
    }
}
