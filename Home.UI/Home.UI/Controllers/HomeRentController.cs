using Aplication.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeRentController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeRentController(IHomeService homeService)
        {
            _homeService = homeService;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeRent(int Id)
        {
            var response = await _homeService.GetByIdHomeRentAynce(Id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


    }
}
