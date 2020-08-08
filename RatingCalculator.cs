using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    class RatingCalculator
    {
        RatingStrategy strategy;

        public double CalculateRating()
        {
            // if(strategy - health)
            strategy = new HealthRatingStrategy();
            strategy.getRating();
            //  else if(strategy - user)
            strategy = new UserRatingStrategy();
            strategy.getRating();
            return 0;
        }
    }
}
