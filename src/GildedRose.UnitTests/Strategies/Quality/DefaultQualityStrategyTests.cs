using GildedRose.Core.Items;
using GildedRose.Core.Strategies.Quality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests.Strategies.Quality
{
    [TestClass]
    public class DefaultQualityStrategyTests
    {
        private DefaultQualityStrategy strategy;

        public DefaultQualityStrategyTests()
        {
            strategy = new DefaultQualityStrategy();
        }

        [TestMethod]
        public void QualityDecreasesByOneWhenSellInIsGreaterThanOrEqualToZero()
        {
            var item = new Item();
            item.Quality = 49;
            item.SellIn = 0;

            strategy.UpdateQuality(item);

            Assert.AreEqual(48, item.Quality);
        }

        [TestMethod]
        public void QualityDecreasesByTwoWhenSellInIsGreaterThanOrEqualToZero()
        {
            var item = new Item();
            item.Quality = 49;
            item.SellIn = -1;

            strategy.UpdateQuality(item);

            Assert.AreEqual(47, item.Quality);
        }
    }
}
