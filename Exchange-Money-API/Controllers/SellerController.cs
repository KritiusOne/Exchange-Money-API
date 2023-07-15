using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {
        private readonly IService<SellersEntity, SellersModel> _service;
        public SellersController(IService<SellersEntity, SellersModel> service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllSellers()
        {
            List<SellersEntity> sellerEntities = _service.GetAll();
            return Ok(sellerEntities);
        }
        [HttpPost]
        public IActionResult CreateSellers(SellersModel seller)
        {
            _service.Create(seller);
            return Ok(seller);
        }
        [HttpPut("/seller/{id}")]
        public IActionResult UpdateSellers(SellersModel seller, int id)
        {
            _service.Update(seller, id);
            return Ok(seller);
        }
        [HttpDelete("/seller/{id}")]
        public IActionResult DeleteSellers(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
