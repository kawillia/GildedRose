using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class AgedBrieQualityStrategy : IQualityStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
                item.Quality++;
        }
    }
}
