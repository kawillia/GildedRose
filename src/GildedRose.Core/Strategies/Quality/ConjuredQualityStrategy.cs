using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class ConjuredQualityStrategy : IQualityStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn < 0)
                item.Quality -= 4;
            else
                item.Quality -= 2;
        }
    }
}
