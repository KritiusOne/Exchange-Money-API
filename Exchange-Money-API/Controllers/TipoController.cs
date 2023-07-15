using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoController : ControllerBase
    {
        private readonly IService<TipoEntity, TipoModel> _service;
        public TipoController(IService<TipoEntity, TipoModel> service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllTipos()
        {
            List<TipoEntity> tipoEntities = _service.GetAll();
            return Ok(tipoEntities);
        }
        [HttpPost]
        public IActionResult CreateTipo(TipoModel tipo)
        {
            _service.Create(tipo);
            return Ok(tipo);
        }
        [HttpPut("/tipo/{id}")]
        public IActionResult UpdateTipo(TipoModel tipo, int id)
        {
            _service.Update(tipo, id);
            return Ok(tipo);
        }
        [HttpDelete("/tipo/{id}")]
        public IActionResult DeleteTipo(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
