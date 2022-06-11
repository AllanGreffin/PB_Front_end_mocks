using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PB_Front_end_mocks.Mocks_statics;
using PB_Front_end_mocks.Models;

namespace PB_Front_end_mocks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        [HttpGet]
        [Route("GetAllLocations")]
        public List<Location> GetAllLocations()
        {
            return PlaceStatic.GetAllLocations();
        }

        [HttpGet]
        [Route("GetAllEmergencyLocations")]
        public List<EmergencyLocation> GetAllEmergencyLocations()
        {
            return PlaceStatic.GetAllEmergencyLocations();
        }

        [HttpGet]
        [Route("GetLocationById")]
        public Location GetLocationById([FromQuery] Guid id)
        {
            return PlaceStatic.GetLocationById(id);
        }

        [HttpGet]
        [Route("GetEmergencyLocationById")]
        public EmergencyLocation GetEmergencyLocationById([FromQuery] Guid id)
        {
            return PlaceStatic.GetEmergencyLocationById(id);
        }
    }
}
