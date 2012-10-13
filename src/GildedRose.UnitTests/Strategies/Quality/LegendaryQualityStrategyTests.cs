using GildedRose.Core.Items;
using GildedRose.Core.Strategies.Quality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests.Strategies.Quality
{
    [TestClass]
    public class LegendaryQualityStrategyTests
    {
        private LegendaryQualityStrategy strategy;

        public LegendaryQualityStrategyTests()
        {
            strategy = new LegendaryQualityStrategy();
        }

        [TestMethod]
        public void QualityDoesNotChange()
        {
            var item = new Item();
            item.Quality = 49;
            item.SellIn = 0;

            strategy.UpdateQuality(item);

            Assert.AreEqual(49, item.Quality);
        }
    }
}
