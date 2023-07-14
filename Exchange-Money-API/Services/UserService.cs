using Exchange_Money_API.Data;
using Exchange_Money_API.Models;

namespace Exchange_Money_API.Services
{
    public class UserService : IService<UserEntity, UserModel>
    {
        private readonly ExchangeMoneyContext _Dbcontext;
        public UserService(ExchangeMoneyContext context) {
            _Dbcontext = context;
        }

        public void Create(UserModel user)
        {
            UserEntity userEntity = new UserEntity();
            {
                userEntity.UserName = user.UserName;
                userEntity.Role_id = user.Role_id;
                userEntity.Ingresos = user.Ingresos;
                userEntity.Egresos = user.Egresos;
                userEntity.Ahorros = user.Ahorros;
            }
            _Dbcontext.Users.Add(userEntity);
            _Dbcontext.SaveChanges();
        }
        public UserEntity GetById(int id)
        {
            return _Dbcontext.Users.Find(id);
        }
        public void Update(UserModel user, int id)
        {
            UserEntity userEntity = GetById(id);
            userEntity.UserName = user.UserName;
            userEntity.Role_id = user.Role_id;
            userEntity.Ingresos = user.Ingresos;
            userEntity.Egresos = user.Egresos;
            userEntity.Ahorros = user.Ahorros;
            _Dbcontext.Users.Update(userEntity);
            _Dbcontext.SaveChanges();
        }
        public void Delete(int id)
        {
            UserEntity user = GetById(id);
            _Dbcontext.Users.Remove(user);
            _Dbcontext.SaveChanges();
        }
        public List<UserEntity> GetAll()
        {
            return _Dbcontext.Users.ToList();
        }

    }
}
