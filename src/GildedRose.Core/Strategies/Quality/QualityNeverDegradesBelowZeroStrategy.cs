using System;
using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class QualityNeverDegradesBelowZeroStrategy : IQualityStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.Quality = Math.Max(item.Quality, 0);
        }
    }
}
