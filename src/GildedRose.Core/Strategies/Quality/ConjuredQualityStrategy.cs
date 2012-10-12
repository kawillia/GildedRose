using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class ConjuredQualityStrategy : QualityStrategyDecorator
    {
        public ConjuredQualityStrategy(IQualityStrategy strategy)
            : base(strategy) { }

        public override void UpdateQuality(Item conjuredItem)
        {
            if (conjuredItem.SellIn < 0)
                conjuredItem.Quality -= 4;
            else
                conjuredItem.Quality -= 2;

            base.UpdateQuality(conjuredItem);
        }
    }
}
