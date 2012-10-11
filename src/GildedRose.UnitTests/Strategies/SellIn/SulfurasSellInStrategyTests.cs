using GildedRose.Core.Items;
using GildedRose.Core.Strategies.SellIn;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.UnitTests.Strategies.SellIn
{
    [TestClass]
    public class SulfurasSellInStrategyTests
    {
        private SulfurasSellInStrategy strategy;

        public SulfurasSellInStrategyTests()
        {
            strategy = new SulfurasSellInStrategy();
        }

        [TestMethod]
        public void DoesNotChange()
        {
            var item = new Item();
            item.SellIn = 0;

            strategy.UpdateSellIn(item);

            Assert.AreEqual(0, item.SellIn);
        }
    }
}
