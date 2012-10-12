using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class DefaultQualityStrategy : QualityStrategyDecorator
    {
        public DefaultQualityStrategy(IQualityStrategy strategy) 
            : base(strategy) { }

        public override void UpdateQuality(Item item)
        {
            if (item.SellIn < 0)
                item.Quality -= 2;
            else
                item.Quality -= 1;

            base.UpdateQuality(item);
        }
    }
}
