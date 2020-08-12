using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodRecipe
{
    class UserRatingStrategy : RatingStrategy
    {

        public double getRating(Recipe r)
        {
            return r.getLikes();
        }
    }
}
