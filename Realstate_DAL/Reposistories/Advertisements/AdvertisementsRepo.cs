using Project_realestate.Data.Models;
using realestate_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate_DAL
{
    public class AdvertisementsRepo : GenericRepo<Advertisement>, IAdvertisementsRepo
    {
        private readonly RealstateContext _Context;
        public AdvertisementsRepo(RealstateContext context) :base(context)
        {
            _Context = context;
        }
        
        public List<Advertisement> GetAdsByCompanyId(int companyId)
        {
            throw new NotImplementedException();
        }

        public List<Advertisement> GetAdsByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Advertisement> GetFiltered(string? type, string? city, int? noOfRooms)
        {
            return _Context.Advertisements
                .Where(a => type == null || type == a.Type)
                .Where(a =>city==null||city==a.City)
                .Where(a=>noOfRooms==null||noOfRooms==a.No_Of_Rooms).ToList();         

        }
    }
}
