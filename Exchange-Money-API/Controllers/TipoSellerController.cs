using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoSellerController : ControllerBase
    {
        private readonly IService<TipoSellerEntity, TipoSellerModel> _service;
        public TipoSellerController(IService<TipoSellerEntity, TipoSellerModel> service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllTipoSellers()
        {
            List<TipoSellerEntity> tipoSellerEntities = _service.GetAll();
            return Ok(tipoSellerEntities);
        }
        [HttpPost]
        public IActionResult CreateTipoSeller(TipoSellerModel tipoSeller)
        {
            _service.Create(tipoSeller);
            return Ok(tipoSeller);
        }
        [HttpPut("/tipoSeller/{id}")]
        public IActionResult UpdateTipoSeller(TipoSellerModel tipoSeller, int id)
        {
            _service.Update(tipoSeller, id);
            return Ok(tipoSeller);
        }
        [HttpDelete("/tipoSeller/{id}")]
        public IActionResult DeleteTipoSeller(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
