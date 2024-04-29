using Aplication.Service;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly  IHomeService _homeService;

        public HotelController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHotelRent()
        {
            var response = await _homeService.GetAllHotelAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

    }
}
