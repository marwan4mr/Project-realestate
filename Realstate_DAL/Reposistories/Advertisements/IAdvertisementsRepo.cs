using Project_realestate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate_DAL
{
    internal interface IAdvertisementsRepo:IGenericRepo<Advertisement>
    {
        List<Advertisement> GetAdsByUserId(int userId); 
        List<Advertisement> GetAdsByCompanyId(int companyId);
        List<Advertisement> GetAdsByCity(string City);
        List<Advertisement> GetAdsByDate(DateTime date);
        List<Advertisement> GetAdsByType(string type);
    }
}
