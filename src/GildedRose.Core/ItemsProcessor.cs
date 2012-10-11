using System.Collections.Generic;
using GildedRose.Core.Items;
using GildedRose.Core.Strategies.Quality;
using GildedRose.Core.Strategies.SellIn;

namespace GildedRose.Core
{
    public class ItemsProcessor
    {
        private IEnumerable<Item> items;

        public ItemsProcessor(IEnumerable<Item> items)
        {
            this.items = items;
        }

        public void Process()
        {
            foreach (var item in items)
                ProcessItem(item);
        }

        private static void ProcessItem(Item item)
        {
            var sellInStrategy = SellInStrategyFactory.GetStrategy(item);
            sellInStrategy.UpdateSellIn(item);

            if (item.Quality > 0)
            {
                var qualityStrategy = QualityStrategyFactory.GetStrategy(item);
                qualityStrategy.UpdateQuality(item);
            }
        }
    }
}
