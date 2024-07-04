using Aplication.Service;
using Domain.Entitys.Home.Services;
using Domain.Entitys.Home.SpareParts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeRepairController : ControllerBase
    {
        private readonly IHomeRepair _homeRepair;

        public HomeRepairController(IHomeRepair homeRepair)
        {
            _homeRepair = homeRepair;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomeRepair()
        {
            var response = await _homeRepair.GetAllHomeRepairAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeRepair(int id)
        {
            var response = await _homeRepair.GetByIdHomeRepairAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] HomeRepair HomeRepair)
        {
            var response = await _homeRepair.UpdateHomeRepairAynce(HomeRepair);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] HomeRepair HomeRepair)
        {
            var response = await _homeRepair.CreateHomeRepairAynce(HomeRepair);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _homeRepair.DeleteHomeRepairAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


    }
}
