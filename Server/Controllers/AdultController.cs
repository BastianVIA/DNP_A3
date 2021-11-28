using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Server.Persistence;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController : ControllerBase
    {
        private IAdultRepo _adultRepo;

        public AdultController(IAdultRepo adultRepo)
        {
            _adultRepo = adultRepo;
        }
        
        [HttpGet]
        public ActionResult<IList<Adult>> GetAdults()
        {
            IList<Adult> adults = _adultRepo.GetAdults();
            return Ok(adults);
        }

        [HttpPost]
        public ActionResult<Adult> AddAdult([FromBody] Adult adult)
        {
            try
            {
                _adultRepo.AddAdult(adult);
            }
            catch (Exception e)
            {
                return BadRequest("Adult creation failed");
            }
            
            return Created("Adult with id: " + adult.Id, adult);
        }

        [HttpDelete]
        public ActionResult RemoveAdult([FromQuery] int id)
        {
            try
            {
                Adult adult = _adultRepo.GetAdults().First(a => a.Id == id);
                _adultRepo.RemoveAdult(adult);
            }
            catch (Exception e)
            {
                return NotFound();
            }
            
            return Ok();
        }
    }
}