using GildedRose.Core.Items;
using GildedRose.Core.Strategies.Quality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests.Strategies.Quality
{
    [TestClass]
    public class AgedBrieQualityStrategyTests
    {
        private AgedBrieQualityStrategy strategy;

        public AgedBrieQualityStrategyTests()
        {
            strategy = new AgedBrieQualityStrategy();
        }

        [TestMethod]
        public void QualityDoesNotGoAboveFifty()
        {
            var item = new AgedBrie();
            item.Quality = 50;

            strategy.UpdateQuality(item);

            Assert.AreEqual(50, item.Quality);
        }

        [TestMethod]
        public void QualityIncreasesByOne()
        {
            var item = new AgedBrie();
            item.Quality = 49;

            strategy.UpdateQuality(item);

            Assert.AreEqual(50, item.Quality);
        }
    }
}
