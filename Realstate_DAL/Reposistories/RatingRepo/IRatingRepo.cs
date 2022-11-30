using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate_DAL;

public interface IRatingRepo : IGenericRepo<Rating> 
{
    Rating? GetRatingOfUserById(Guid RecivedUserId);

    Rating? GetRating(Guid RecivedId);
}
