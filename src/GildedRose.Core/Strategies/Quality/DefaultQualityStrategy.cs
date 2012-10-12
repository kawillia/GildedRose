using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class DefaultQualityStrategy : IQualityStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn < 0)
                item.Quality -= 2;
            else
                item.Quality -= 1;

            if (item.Quality < 0)
                item.Quality = 0;
        }
    }
}
