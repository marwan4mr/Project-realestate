using AutoMapper;
using Project_realestate.Data.Models;
using Realstate_BL.DTOs.Advertiaement;
using RealstateDAL;

namespace Realstate_BL
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Advertisement, AdvReadDTO>(); 
            CreateMap<AdvWriteDTO, Advertisement>();
        }
    }
}
