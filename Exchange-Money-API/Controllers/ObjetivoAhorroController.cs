using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetivoAhorroController : ControllerBase
    {
        private readonly IService<ObjetivoAhorroEntity, ObjetivoAhorroModel> _service;
        public ObjetivoAhorroController(IService<ObjetivoAhorroEntity, ObjetivoAhorroModel> service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllObjetivoAhorros()
        {
            List<ObjetivoAhorroEntity> objetivoAhorroEntities = _service.GetAll();
            return Ok(objetivoAhorroEntities);
        }
        [HttpPost]
        public IActionResult CreateObjetivoAhorro(ObjetivoAhorroModel objetivoAhorro)
        {
            _service.Create(objetivoAhorro);
            return Ok(objetivoAhorro);
        }
        [HttpPut("/objetivoAhorro/{id}")]
        public IActionResult UpdateObjetivoAhorro(ObjetivoAhorroModel objetivoAhorro, int id)
        {
            _service.Update(objetivoAhorro, id);
            return Ok(objetivoAhorro);
        }
        [HttpDelete("/objetivoAhorro/{id}")]
        public IActionResult DeleteObjetivoAhorro(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
