using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realstate_BL;
using Realstate_BL.DTOs.Advertiaement;

namespace Project_realestate.Controllers
{
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
        [Route("{city}")]
        public ActionResult<IEnumerable<AdvReadDTO>> GetAdByCity(string city)
        {
            var advDTO = _advManager.GetAdsByCity(city);
            if (advDTO == null)
                return NotFound();
            return advDTO;
        }

        [HttpGet]
        [Route("{type}")]
        public ActionResult<IEnumerable<AdvReadDTO>> GetAdByType(string type)
        {
            var advDTO = _advManager.GetAdsByType(type);
            if (advDTO == null)
                return NotFound();
            return advDTO;
        }

        [HttpDelete]
        public void DeleteAdvirtisement(AdvWriteDTO adv)
        {
            _advManager.DeleteAdvertisement(adv);
        }


    }
}
