using GildedRose.Core.Items;
using GildedRose.Core.Strategies.Quality;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRose.UnitTests.Fakes;

namespace GildedRose.UnitTests.Strategies.Quality
{
    [TestClass]
    public class AgedBrieQualityStrategyTests
    {
        private AgedBrieQualityStrategy strategy;

        public AgedBrieQualityStrategyTests()
        {
            strategy = new AgedBrieQualityStrategy(new FakeQualityStrategy());
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
