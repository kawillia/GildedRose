using GildedRose.Core.Items;
using GildedRose.Core.Strategies.Quality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests.Strategies.Quality
{
    [TestClass]
    public class QualityStrategyFactoryTests
    {
        [TestMethod]
        public void GetStrategyReturnsNormalQualityStrategyForNormalItem()
        {
            var strategy = QualityStrategyFactory.GetStrategy(new Item());

            Assert.IsInstanceOfType(strategy, typeof(DefaultQualityStrategy));
        }

        [TestMethod]
        public void GetStrategyReturnsAgedBrieQualityStrategyForAgedBrie()
        {
            var strategy = QualityStrategyFactory.GetStrategy(new AgedBrie());

            Assert.IsInstanceOfType(strategy, typeof(AgedBrieQualityStrategy));
        }

        [TestMethod]
        public void GetStrategyReturnsSulfurasQualityStrategyForSulfuras()
        {
            var strategy = QualityStrategyFactory.GetStrategy(new Sulfuras());

            Assert.IsInstanceOfType(strategy, typeof(SulfurasQualityStrategy));
        }

        [TestMethod]
        public void GetStrategyReturnsBackStagePassQualityStrategyForBackstagePass()
        {
            var strategy = QualityStrategyFactory.GetStrategy(new BackstagePass());

            Assert.IsInstanceOfType(strategy, typeof(BackstagePassQualityStrategy));
        }

        [TestMethod]
        public void GetStrategyReturnsConjuredQualityStrategyForConjured()
        {
            var strategy = QualityStrategyFactory.GetStrategy(new Conjured());

            Assert.IsInstanceOfType(strategy, typeof(ConjuredQualityStrategy));
        }
    }
}
