using Aplication.Service;
using Domain.Entitys.Home.SpareParts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeApplianceController : ControllerBase
    {
        private readonly IHomeAppliance _homeAppliance;

        public HomeApplianceController(IHomeAppliance homeAppliance)
        {
            _homeAppliance = homeAppliance;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomeAppliance()
        {
            var response = await _homeAppliance.GetAllHomeApplianceAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeAppliance(int id)
        {
            var response = await _homeAppliance.GetByIdHomeApplianceAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] HomeAppliance HomeAppliance)
        {
            var response = await _homeAppliance.UpdateHomeApplianceAynce(HomeAppliance);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] HomeAppliance HomeAppliance)
        {
            var response = await _homeAppliance.CreateHomeApplianceAynce(HomeAppliance);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _homeAppliance.DeleteHomeApplianceAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
