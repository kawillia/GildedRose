using GildedRose.Core.Items;
using GildedRose.Core.Strategies.Quality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests.Strategies.Quality
{
    [TestClass]
    public class QualityNeverIncreasesAboveFiftyStrategyTests
    {
        private QualityNeverIncreasesAboveFiftyStrategy strategy;

        public QualityNeverIncreasesAboveFiftyStrategyTests()
        {
            strategy = new QualityNeverIncreasesAboveFiftyStrategy();
        }

        [TestMethod]
        public void QualityDoesNotGoAboveFifty()
        {
            var item = new Item();
            item.Quality = 51;

            strategy.UpdateQuality(item);

            Assert.AreEqual(50, item.Quality);
        }
    }
}
