using Aplication.Service;
using Domain.Entitys.Home;
using Domain.Entitys.Home.SpareParts;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHotel()
        {
            var response = await _hotelService.GetAllHotelAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHotel(int id)
        {
            var response = await _hotelService.GetByIdHotelAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] Hotel Hotel)
        {
            var response = await _hotelService.UpdateHotelAynce(Hotel);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] Hotel Hotel)
        {
            var response = await _hotelService.CreateHotelAynce(Hotel);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _hotelService.DeleteHotelAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
