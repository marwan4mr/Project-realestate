using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate_DAL;

public interface IRatingRepo : IGenericRepo<Rating> 
{
    //Rating? GetRatingOfUsers(Guid GetRatingId);

    Rating? GetRating(Guid RecivedId);
}
