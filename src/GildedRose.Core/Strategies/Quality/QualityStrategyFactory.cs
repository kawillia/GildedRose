using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public static class QualityStrategyFactory
    {
        public static IQualityStrategy GetStrategy(Item item)
        {
            if (item is AgedBrie)
                return new AgedBrieQualityStrategy(new QualityNeverIncreasesAboveFiftyStrategy());

            if (item is LegendaryItem)
                return new LegendaryQualityStrategy();

            if (item is BackstagePass)
                return new BackstagePassQualityStrategy(new QualityNeverIncreasesAboveFiftyStrategy());

            if (item is ConjuredItem)
                return new ConjuredQualityStrategy(new QualityNeverDegradesBelowZeroStrategy());

            return new DefaultQualityStrategy(new QualityNeverDegradesBelowZeroStrategy());
        }
    }
}
