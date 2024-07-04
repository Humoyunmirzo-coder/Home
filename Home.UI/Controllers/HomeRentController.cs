using Aplication.Service;
using Domain.Entitys.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeRentController : ControllerBase
    {
      private readonly IHomeRentService _homeRentService;

        public HomeRentController(IHomeRentService homeRentService)
        {
            _homeRentService = homeRentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomesRent()
        {
            var response = await _homeRentService.GetAllHomeRentAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeRent(int Id)
        {
            var response = await _homeRentService.GetByIdHomeRentAynce(Id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }
   

        [HttpPut]
        public async Task<IActionResult> UpdateHomeRent([FromBody] HomeRent homeRent)
        {
            var response = await _homeRentService.UpdateHomeRentAynce(homeRent);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHomeRent([FromBody] HomeRent homeRent)
        {
            var response = await _homeRentService.CreateHomeRentAynce(homeRent);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomeRent (int id)
        {
            var response = await _homeRentService.DeleteHomeRentAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
