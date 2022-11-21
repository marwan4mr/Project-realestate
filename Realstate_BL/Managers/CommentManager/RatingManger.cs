using AutoMapper;
using Realstate_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate_BL;

public class RatingManger : IRatingManger
{
    private readonly IRatingRepo _ratingRepo;
    private readonly IMapper _mapper;

    public RatingManger(IRatingRepo ratingRepo,IMapper mapper)
    {
        _ratingRepo = ratingRepo;
        _mapper = mapper;
    }

    public void AddRating(RatingWriteDTOs RatingDTOs)
    {

        var dbRating =_mapper.Map<Rating>(RatingDTOs);
        _ratingRepo.Add(dbRating);
        _ratingRepo.SaveChanges();
    }

    public Rating? GetRatingOfUserById(Guid GetRatingId)
    {
        return default;
    }
}
