using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IService<RoleEntity, RoleModel> _service;
        public RoleController(IService<RoleEntity, RoleModel> service)
        {
            this._service = service;
        }
        [HttpGet]
        public IActionResult GetAll() {
            List<RoleEntity> roles = _service.GetAll();
            return Ok(roles);
        }
        [HttpPost]
        public IActionResult CreateRole(RoleModel role)
        {
            _service.Create(role);
            return Ok(role);
        }
        [HttpPut("/role/{id}")]
        public IActionResult UpdateRole(RoleModel role, int id)
        {
            _service.Update(role, id);
            return Ok(role);
        }
        [HttpDelete("/role/{id}")]
        public IActionResult DeleteRole(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
