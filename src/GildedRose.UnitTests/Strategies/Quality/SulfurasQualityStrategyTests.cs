using GildedRose.Core.Items;
using GildedRose.Core.Strategies.Quality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests.Strategies.Quality
{
    [TestClass]
    public class SulfurasQualityStrategyTests
    {
        private SulfurasQualityStrategy strategy;

        public SulfurasQualityStrategyTests()
        {
            strategy = new SulfurasQualityStrategy();
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
