using AutoMapper;
using Project_realestate.Data.Models;
using Realstate_BL.DTOs.Advertiaement;
using Realstate_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate_BL
{
    public class AdvManager : IAdvManager
    {
        private readonly IAdvertisementsRepo _AdvRepo;
        private readonly IMapper _mapper;

        public AdvManager(IAdvertisementsRepo advertisementsRepo,IMapper mapper)
        {
            _AdvRepo=advertisementsRepo;
            _mapper = mapper;
        }
        public void AddAdvertisement(AdvWriteDTO ad)
        {
           var dbAd= _mapper.Map<Advertisement>(ad);
            _AdvRepo.Add(dbAd);
            _AdvRepo.SaveChanges();
                
        }

        public void DeleteAdvertisement(AdvWriteDTO ad)
        {
            var dbAdv= _mapper.Map<Advertisement>(ad);
            _AdvRepo.Delete(dbAdv);
            _AdvRepo.SaveChanges();

        }

        public List<AdvReadDTO> GetAdsByCompanyId(Guid companyId)
        {
            throw new NotImplementedException();
        }


        public List<AdvReadDTO> GetAdsByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public AdvReadDTO? GetAdvById(Guid id)
        {
            var dbAdv = _AdvRepo.GetById(id);
            if(dbAdv is null)
                return null;
            return _mapper.Map<AdvReadDTO>(dbAdv);

        }

        public List<AdvReadDTO> GetAllAds()
        {
            var dbAds = _AdvRepo.GetAll();
            var DTOAds= _mapper.Map<List<AdvReadDTO>>(dbAds);
            return DTOAds;
        }

        public List<AdvReadDTO> GetFiltered(string? type, string? City, int? noOfRooms)
        {
            var dbAD = _AdvRepo.GetFiltered(type, City, noOfRooms);

            return _mapper.Map<List<AdvReadDTO>>(dbAD);
        }

        public void UpdateAdvertisement(AdvWriteDTO ad)
        {
            throw new NotImplementedException();
        }
    }
}
