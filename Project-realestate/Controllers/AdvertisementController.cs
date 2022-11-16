using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realstate_BL;
using Realstate_BL.DTOs.Advertiaement;

namespace Project_realestate.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementController : ControllerBase
    {
        private readonly IAdvManager _advManager;
        public AdvertisementController(IAdvManager advManager)
        {
            _advManager=advManager;
        }

        [HttpGet]  
        public ActionResult<IEnumerable<AdvReadDTO>> GetAllAds()
        {
            return _advManager.GetAllAds();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<AdvReadDTO> GetAdById(int id)
        {
            var advDTO= _advManager.GetAdvById(id);
            if(advDTO == null)   
                return NotFound();
            return advDTO;
        }

        [HttpPost]
        public void AddAdvirtisement(AdvWriteDTO adv)
        {
            _advManager.AddAdvertisement(adv);

        }

      

        [HttpGet]
        [Route("{filter}")]
        public ActionResult<IEnumerable<AdvReadDTO>> GetFiltered(string? type,string? city,int noOfRooms)
        {
            return _advManager.GetFiltered(type, city, noOfRooms);
          
        }

        [HttpDelete]
        public void DeleteAdvirtisement(AdvWriteDTO adv)
        {
            _advManager.DeleteAdvertisement(adv);
        }


    }
}
