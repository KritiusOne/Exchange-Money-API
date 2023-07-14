using Exchange_Money_API.Data;
using Exchange_Money_API.Models;
using Microsoft.Identity.Client;

namespace Exchange_Money_API.Services
{
    public class RoleService : IService<RoleEntity, RoleModel>
    {
        private readonly ExchangeMoneyContext _Dbcontext;
        public RoleService(ExchangeMoneyContext dbcontext)
        {
            _Dbcontext = dbcontext;
        }

        public void Create(RoleModel role)
        {
            RoleEntity roleEntity = new RoleEntity();
            {
                roleEntity.Role = role.Role;
                roleEntity.Users = role.Users;
            }
            _Dbcontext.Roles.Add(roleEntity);
            _Dbcontext.SaveChanges();
        }
        public RoleEntity GetById(int id)
        {
            return _Dbcontext.Roles.Find(id);
        }
        public List<RoleEntity> GetAll()
        {
            return _Dbcontext.Roles.ToList();
        }
        public void Update(RoleModel role, int id) {
            RoleEntity roleEntity = GetById(id);
            {
                roleEntity.Role = role.Role;
                roleEntity.Users = role.Users;
            }
            _Dbcontext.SaveChanges();
        }
        public void Delete(int id)
        {
            RoleEntity roleEntity = GetById(id);
            _Dbcontext.Roles.Remove(roleEntity);
            _Dbcontext.SaveChanges();
        }
    }
}
