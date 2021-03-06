﻿using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.SellIn
{
    public static class SellInStrategyFactory
    {
        public static ISellInStrategy GetStrategy(Item item)
        {
            if (item is LegendaryItem)
                return new SulfurasSellInStrategy();

            return new DefaultSellInStrategy();
        }
    }
}
