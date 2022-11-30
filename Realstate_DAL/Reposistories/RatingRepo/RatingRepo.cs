﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Realstate_DAL;

public class RatingRepo : GenericRepo<Rating>, IRatingRepo
{
    private readonly RealstateContext _context;

    public RatingRepo(RealstateContext context):base(context)
    {
        _context = context;
    }

    

    public Rating? GetRating(Guid RecivedId)
    {
        return _context.Ratings.FirstOrDefault(a => a.ReciveRatingId == RecivedId);
    }

    public Rating? GetRatingOfUserById(Guid UserId)
    {
        return _context.Ratings.FirstOrDefault(r => r.ReciveRatingId == UserId);
    }
}
