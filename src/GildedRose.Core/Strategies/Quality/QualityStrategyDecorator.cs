using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class QualityStrategyDecorator : IQualityStrategy
    {
        private IQualityStrategy strategy;

        public QualityStrategyDecorator(IQualityStrategy strategy)
        {
            this.strategy = strategy;
        }

        public virtual void UpdateQuality(Item item)
        {
            strategy.UpdateQuality(item);
        }
    }
}
