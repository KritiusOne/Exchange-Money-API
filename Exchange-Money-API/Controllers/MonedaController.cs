using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : ControllerBase
    {
        private readonly IService<MonedaEntity, MonedaModel> _service;
        public MonedaController(IService<MonedaEntity, MonedaModel> service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllMonedas()
        {
            List<MonedaEntity> monedaEntities = _service.GetAll();
            return Ok(monedaEntities);
        }
        [HttpPost]
        public IActionResult CreateMoneda(MonedaModel moneda)
        {
            _service.Create(moneda);
            return Ok(moneda);
        }
        [HttpPut("/moneda/{id}")]
        public IActionResult UpdateMoneda(MonedaModel moneda, int id)
        {
            _service.Update(moneda, id);
            return Ok(moneda);
        }
        [HttpDelete("/moneda/{id}")]
        public IActionResult DeleteMoneda(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
