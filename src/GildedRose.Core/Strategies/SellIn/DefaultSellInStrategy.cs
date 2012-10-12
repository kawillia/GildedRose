using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.SellIn
{
    public class DefaultSellInStrategy : ISellInStrategy
    {
        public void UpdateSellIn(Item item)
        {
            item.SellIn--;
        }
    }
}
