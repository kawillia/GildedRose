using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class AgedBrieQualityStrategy : QualityStrategyDecorator
    {
        public AgedBrieQualityStrategy(IQualityStrategy strategy) 
            : base(strategy) { }

        public override void UpdateQuality(Item brie)
        {
            brie.Quality++;

            base.UpdateQuality(brie);
        }
    }
}
