﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realstate_BL;

namespace Project_realestate.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementController : ControllerBase
    {
        private readonly IAdvManager _advManager;
        public AdvertisementController(IAdvManager advManager)
        {
            _advManager = advManager;
        }
        //-------------get all ads-------------------------------------------
        [HttpGet]
        public ActionResult<IEnumerable<AdvReadDTO>> GetAllAds()
        {
            return _advManager.GetAllAds();
        }
        //------------------------------get ad by id--------------------------------
        [HttpGet]
        [Route("GetAdById/{id}")]
        public ActionResult<AdvReadDTO> GetAdById(Guid id)
        {
            var advDTO = _advManager.GetAdvById(id);
            if (advDTO == null)
                return NotFound();
            return advDTO;
        }
        //-----------------------adding adv-------------------------------------------------------

        [HttpPost]
        public void AddAdvirtisement(AdvWriteDTO adv)
        {
            _advManager.AddAdvertisement(adv);

        }


        //----------------------------------filtering ads according to  type/city/no.of rooms----------------
        [HttpGet]
        [Route("filter")]
        public ActionResult<IEnumerable<AdvReadDTO>> GetFiltered(string? type, string? city, int noOfRooms)
        {
            return _advManager.GetFiltered(type, city, noOfRooms);

        }
        //----------------------------deleting ads------------------------------
        [HttpDelete]
        public void DeleteAdvirtisement(AdvWriteDTO adv)
        {
            _advManager.DeleteAdvertisement(adv);
        }

//---------------------------------------------------------
        [HttpGet]
        [Route("GetAdByUserId/{id}")]
        public ActionResult<IEnumerable<AdvReadDTO>> GetAdByUserId(Guid id)
        {
            var advDTO = _advManager.GetAdsByUserId(id);
            if (advDTO == null)
                return NotFound();
            return advDTO;
        }
//-------------------------------------------------------------------------

        [HttpGet]
        [Route("GetAdByCompanyId/{id}")]
        public ActionResult<IEnumerable<AdvReadDTO>> GetAdByCompanyId(Guid id)
        {
            var advDTO = _advManager.GetAdsByCompanyId(id);
            if (advDTO == null)
                return NotFound();
            return advDTO;
        }




    }
}
