using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class BackstagePassQualityStrategy : IQualityStrategy
    {
        public void UpdateQuality(Item backstagePass)
        {
            if (backstagePass.SellIn > 0)
            {
                backstagePass.Quality++;

                if (backstagePass.SellIn <= 10)
                    backstagePass.Quality++;

                if (backstagePass.SellIn <= 5)
                    backstagePass.Quality++;

                if (backstagePass.Quality >= 50)
                    backstagePass.Quality = 50;
            }
            else
            {
                backstagePass.Quality = 0;
            }            
        }
    }
}
