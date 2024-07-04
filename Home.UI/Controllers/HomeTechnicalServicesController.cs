using Aplication.Service;
using Domain.Entitys.Home.Services;
using Domain.Entitys.Home.SpareParts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeTechnicalServicesController : ControllerBase
    {
        private readonly ITechnicalServices _technicalServices;

        public HomeTechnicalServicesController(ITechnicalServices technicalServices)
        {
            _technicalServices = technicalServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTechnicalServices()
        {
            var response = await _technicalServices.GetAllTechnicalServicesAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdTechnicalServices(int id)
        {
            var response = await _technicalServices.GetByIdTechnicalServicesAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] TechnicalServices TechnicalServices)
        {
            var response = await _technicalServices.UpdateTechnicalServicesAynce(TechnicalServices);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] TechnicalServices TechnicalServices)
        {
            var response = await _technicalServices.CreateTechnicalServicesAynce(TechnicalServices);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _technicalServices.DeleteTechnicalServicesAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
