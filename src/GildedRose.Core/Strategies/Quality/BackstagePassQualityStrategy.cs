using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class BackstagePassQualityStrategy : QualityStrategyDecorator
    {
        public BackstagePassQualityStrategy(IQualityStrategy strategy)
            : base(strategy)
        { }

        public override void UpdateQuality(Item backstagePass)
        {
            if (backstagePass.SellIn > 0)
            {
                backstagePass.Quality++;

                if (backstagePass.SellIn <= 10)
                    backstagePass.Quality++;

                if (backstagePass.SellIn <= 5)
                    backstagePass.Quality++;
            }
            else
            {
                backstagePass.Quality = 0;
            }

            base.UpdateQuality(backstagePass);
        }
    }
}
