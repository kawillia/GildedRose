using System.Collections.Generic;
using GildedRose.Core.Items;
using GildedRose.Core.Strategies.Quality;
using GildedRose.Core.Strategies.SellIn;

namespace GildedRose.Core
{
    public class InventoryUpdater
    {
        private IEnumerable<Item> items;

        public InventoryUpdater(IEnumerable<Item> items)
        {
            this.items = items;
        }

        public void Update()
        {
            foreach (var item in items)
                UpdateItem(item);
        }

        private static void UpdateItem(Item item)
        {
            var sellInStrategy = SellInStrategyFactory.GetStrategy(item);
            sellInStrategy.UpdateSellIn(item);

            var qualityStrategy = QualityStrategyFactory.GetStrategy(item);
            qualityStrategy.UpdateQuality(item);
        }
    }
}
