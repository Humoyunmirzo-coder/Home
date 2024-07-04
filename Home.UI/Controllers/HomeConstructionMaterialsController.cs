using Aplication.Service;
using Domain.Entitys.Home.SpareParts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeConstructionMaterialsController : ControllerBase
    {

       private readonly IConstructionMaterials _constructionMaterials;

        public HomeConstructionMaterialsController(IConstructionMaterials constructionMaterials)
        {
            _constructionMaterials = constructionMaterials;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllConstructionMaterials()
        {
            var response = await _constructionMaterials.GetAllConstructionMaterialsAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdConstructionMaterials(int id)
        {
            var response = await _constructionMaterials.GetByIdConstructionMaterialsAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] ConstructionMaterials ConstructionMaterials)
        {
            var response = await _constructionMaterials.UpdateConstructionMaterialsAynce(ConstructionMaterials);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] ConstructionMaterials ConstructionMaterials)
        {
            var response = await _constructionMaterials.CreateConstructionMaterialsAynce(ConstructionMaterials);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _constructionMaterials.DeleteConstructionMaterialsAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
