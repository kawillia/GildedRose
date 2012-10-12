using GildedRose.Core.Items;
using GildedRose.Core.Strategies.Quality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests.Strategies.Quality
{
    [TestClass]
    public class QualityNeverDegradesBelowZeroStrategyTests
    {
        private QualityNeverDegradesBelowZeroStrategy strategy;

        public QualityNeverDegradesBelowZeroStrategyTests()
        {
            strategy = new QualityNeverDegradesBelowZeroStrategy();
        }

        [TestMethod]
        public void QualityDoesNotGoAboveFifty()
        {
            var item = new Item();
            item.Quality = -1;
            strategy.UpdateQuality(item);

            Assert.AreEqual(0, item.Quality);
        }
    }
}
