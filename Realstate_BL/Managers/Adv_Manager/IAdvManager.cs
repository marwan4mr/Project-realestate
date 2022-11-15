using Project_realestate.Data.Models;
using Realstate_BL.DTOs.Advertiaement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate_BL
{
    public interface IAdvManager
    {
        List<AdvReadDTO> GetAllAds();  
        AdvReadDTO? GetAdvById(int id);
        void AddAdvertisement(AdvWriteDTO ad);
        void DeleteAdvertisement(AdvWriteDTO ad);
        void UpdateAdvertisement(AdvWriteDTO ad);
        List<AdvReadDTO> GetAdsByUserId(int userId);
        List<AdvReadDTO> GetAdsByCompanyId(int companyId);
        List<AdvReadDTO> GetFiltered(string? type,string? City,int? noOfRooms);
        
    }
}
