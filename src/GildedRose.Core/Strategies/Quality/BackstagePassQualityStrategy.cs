using GildedRose.Core.Items;

namespace GildedRose.Core.Strategies.Quality
{
    public class BackstagePassQualityStrategy : IQualityStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn > 0)
            {
                item.Quality++;

                if (item.SellIn <= 10)
                    item.Quality++;

                if (item.SellIn <= 5)
                    item.Quality++;

                if (item.Quality >= 50)
                    item.Quality = 50;
            }
            else
            {
                item.Quality = 0;
            }            
        }
    }
}
