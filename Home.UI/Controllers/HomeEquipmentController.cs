using Aplication.Service;
using Domain.Entitys.Home.Services;
using Domain.Entitys.Home.SpareParts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeEquipmentController : ControllerBase
    {
     private readonly IHomeEquipment  _equipment;

        public HomeEquipmentController(IHomeEquipment equipment)
        {
            _equipment = equipment;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomeEquipment()
        {
            var response = await _equipment.GetAllHomeEquipmentAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeEquipment(int id)
        {
            var response = await _equipment.GetByIdHomeEquipmentAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] HomeEquipment HomeEquipment)
        {
            var response = await _equipment.UpdateHomeEquipmentAynce(HomeEquipment);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] HomeEquipment HomeEquipment)
        {
            var response = await _equipment.CreateHomeEquipmentAynce(HomeEquipment);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _equipment.DeleteHomeEquipmentAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
