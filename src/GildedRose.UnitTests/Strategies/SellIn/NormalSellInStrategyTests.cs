using GildedRose.Core.Items;
using GildedRose.Core.Strategies.SellIn;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests.Strategies.SellIn
{
    [TestClass]
    public class NormalSellInStrategyTests
    {
        private NormalSellInStrategy strategy;

        public NormalSellInStrategyTests()
        {
            strategy = new NormalSellInStrategy();
        }

        [TestMethod]
        public void DecreasesByOne()
        {
            var item = new Item();
            item.SellIn = 0;

            strategy.UpdateSellIn(item);

            Assert.AreEqual(-1, item.SellIn);
        }
    }
}
