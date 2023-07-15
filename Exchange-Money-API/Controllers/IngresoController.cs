using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresoController : ControllerBase
    {
        private readonly IService<IngresoEntity, IngresoModel> _service;
        public IngresoController(IService<IngresoEntity, IngresoModel> service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllIngreso() {
            List<IngresoEntity> ingresoEntities = _service.GetAll();
            return Ok(ingresoEntities);
        }
        [HttpPost]
        public IActionResult CreateIngreso(IngresoModel ingreso)
        {
            _service.Create(ingreso);
            return Ok(ingreso);
        }
        [HttpPut("/ingreso/{id}")]
        public IActionResult UpdateIngreso(IngresoModel ingreso, int id)
        {
            _service.Update(ingreso, id);
            return Ok(ingreso);
        }
        [HttpDelete("/ingreso/{id}")]
        public IActionResult DeleteIngreso(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
