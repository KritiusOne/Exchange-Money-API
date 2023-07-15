using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AhorroController : ControllerBase
    {
        private readonly IService<AhorroEntity, AhorroModel> _service;
        public AhorroController(IService<AhorroEntity, AhorroModel> service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllAhorros()
        {
            List<AhorroEntity> ahorroEntities = _service.GetAll();
            return Ok(ahorroEntities);
        }
        [HttpPost]
        public IActionResult CreateAhorro(AhorroModel ahorro)
        {
            _service.Create(ahorro);
            return Ok(ahorro);
        }
        [HttpPut("/ahorro/{id}")]
        public IActionResult UpdateAhorro(AhorroModel ahorro, int id)
        {
            _service.Update(ahorro, id);
            return Ok(ahorro);
        }
        [HttpDelete("/ahorro/{id}")]
        public IActionResult DeleteAhorro(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
