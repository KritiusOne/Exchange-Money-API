using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Money_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService<UserEntity, UserModel> _service;
        public UserController(IService<UserEntity, UserModel> service)
        {
            this._service = service;
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            List<UserEntity> userEntities = _service.GetAll();
            return Ok(userEntities);
        }
        [HttpPost]
        public IActionResult CreateUser(UserModel user)
        {
            _service.Create(user);
            return Ok(user);
        }
        [HttpPut("/{id}")]
        public IActionResult UpdateUser(UserModel user, int id)
        {
            _service.Update(user, id);
            return Ok(user);
        }
        [HttpDelete("/{id}")]
        public IActionResult DeleteUser(int id)
        {
            _service.Delete(id);
            return Ok();
        }

    }
}
