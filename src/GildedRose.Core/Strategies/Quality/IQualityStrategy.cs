using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public interface IQualityStrategy
    {
        void UpdateQuality(Item item);
    }
}
