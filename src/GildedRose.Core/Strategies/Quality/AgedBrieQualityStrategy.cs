using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class AgedBrieQualityStrategy : IQualityStrategy
    {
        public void UpdateQuality(Item brie)
        {
            if (brie.Quality < 50)
                brie.Quality++;
        }
    }
}
