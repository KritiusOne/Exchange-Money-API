using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EgresoController : ControllerBase
    {
        private readonly IService<EgresoEntity, EgresoModel> _service;
        public EgresoController(IService<EgresoEntity, EgresoModel> service)
        {
            _service = service;            
        }
        [HttpGet]
        public IActionResult GetAllEgresos()
        {
            List<EgresoEntity> egresoEntities = _service.GetAll();
            return Ok(egresoEntities);
        }
        [HttpPost]
        public IActionResult CreateEgreso(EgresoModel egreso)
        {
            _service.Create(egreso);
            return Ok(egreso);
        }
        [HttpPut("/Egreso/{id}")]
        public IActionResult UpdateEgreso(EgresoModel egreso, int id)
        {
            _service.Update(egreso, id);
            return Ok(egreso);
        }
        [HttpDelete("/Egreso/{id}")]
        public IActionResult DeleteEgreso(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
