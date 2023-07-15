using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcreedorController : ControllerBase
    {
        private readonly IService<AcreedorEntity, AcreedorModel> _service;
        public AcreedorController(IService<AcreedorEntity, AcreedorModel> service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllAcreedors()
        {
            List<AcreedorEntity> acreedorEntities = _service.GetAll();
            return Ok(acreedorEntities);
        }
        [HttpPost]
        public IActionResult CreateAcreedor(AcreedorModel acreedor)
        {
            _service.Create(acreedor);
            return Ok(acreedor);
        }
        [HttpPut("/acreedor/{id}")]
        public IActionResult UpdateAcreedor(AcreedorModel acreedor, int id)
        {
            _service.Update(acreedor, id);
            return Ok(acreedor);
        }
        [HttpDelete("/acreedor/{id}")]
        public IActionResult DeleteAcreedor(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
