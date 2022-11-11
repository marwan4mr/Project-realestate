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
        
        public List<Advertisement> GetAdsByCity(string City)
        {
            return _Context.Advertisements.Where(a => a.City == City).ToList(); 
        }

        public List<Advertisement> GetAdsByCompanyId(int companyId)
        {
            throw new NotImplementedException();
        }

        public List<Advertisement> GetAdsByDate(DateTime date)
        {
            return _Context.Advertisements.Where(a => a.AdvDate==date).ToList();
        }

        public List<Advertisement> GetAdsByType(string type)
        {
            return _Context.Advertisements.Where(a => a.Type==type).ToList();
        }

        public List<Advertisement> GetAdsByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
