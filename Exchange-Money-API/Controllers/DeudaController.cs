using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeudaController : ControllerBase
    {
        private readonly IService<DeudaEntity, DeudaModel> _service;
        public DeudaController(IService<DeudaEntity, DeudaModel> service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllDeudas()
        {
            List<DeudaEntity> deudaEntities = _service.GetAll();
            return Ok(deudaEntities);
        }
        [HttpPost]
        public IActionResult CreateDeuda(DeudaModel deuda)
        {
            _service.Create(deuda);
            return Ok(deuda);
        }
        [HttpPut("/deuda/{id}")]
        public IActionResult UpdateDeuda(DeudaModel deuda, int id)
        {
            _service.Update(deuda, id);
            return Ok(deuda);
        }
        [HttpDelete("/deuda/{id}")]
        public IActionResult DeleteDeuda(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
