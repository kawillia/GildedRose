using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class ConjuredQualityStrategy : IQualityStrategy
    {
        public void UpdateQuality(Item conjuredItem)
        {
            if (conjuredItem.SellIn < 0)
                conjuredItem.Quality -= 4;
            else
                conjuredItem.Quality -= 2;

            if (conjuredItem.Quality < 0)
                conjuredItem.Quality = 0;
        }
    }
}
