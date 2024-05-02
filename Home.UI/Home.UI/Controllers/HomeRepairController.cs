using Aplication.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeRepairController : ControllerBase
    {
        private readonly IHomeService   _homeService;

        public HomeRepairController(IHomeService homeService)
        {
            _homeService = homeService;
        }


    }
}
