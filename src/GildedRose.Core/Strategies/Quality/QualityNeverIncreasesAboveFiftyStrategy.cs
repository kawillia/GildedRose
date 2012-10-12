using System;
using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class QualityNeverIncreasesAboveFiftyStrategy : IQualityStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.Quality = Math.Min(item.Quality, 50);
        }
    }
}
