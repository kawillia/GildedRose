using GildedRose.Core.Items;
using GildedRose.Core.Strategies.SellIn;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests.Strategies.SellIn
{
    [TestClass]
    public class SellInStrategyFactoryTests
    {
        [TestMethod]
        public void GetStrategyReturnsNormalQualityStrategyForNormalItem()
        {
            var strategy = SellInStrategyFactory.GetStrategy(new Item());

            Assert.IsInstanceOfType(strategy, typeof(NormalSellInStrategy));
        }

        [TestMethod]
        public void GetStrategyReturnsAgedBrieQualityStrategyForAgedBrie()
        {
            var strategy = SellInStrategyFactory.GetStrategy(new Sulfuras());

            Assert.IsInstanceOfType(strategy, typeof(SulfurasSellInStrategy));
        }
    }
}
