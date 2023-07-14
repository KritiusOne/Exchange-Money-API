using Exchange_Money_API.Data;
using Exchange_Money_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Exchange_Money_API.Services
{
    public class AhorroService : IService<AhorroEntity, AhorroModel>
    {
        private readonly ExchangeMoneyContext _DbContext;
        public AhorroService(ExchangeMoneyContext dbContext)
        {
            _DbContext = dbContext;
        }
        public void Create(AhorroModel ahorro)
        {
            AhorroEntity ahorroEntity = new AhorroEntity();
            {
                ahorroEntity.Divisa = ahorro.Divisa;
                ahorroEntity.Users = ahorro.Users;
                ahorroEntity.Objetivos = ahorro.Objetivos;


                ahorroEntity.Moneda_id = ahorro.Moneda_id;
                ahorroEntity.User_id = ahorro.User_id;
                ahorroEntity.Objetivo_id = ahorro.Objetivo_id;


                ahorroEntity.ValorAhorro = ahorro.ValorAhorro; 
            }
            _DbContext.Ahorros.Add(ahorroEntity);
            _DbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            AhorroEntity ahorroEntity = GetById(id);
            _DbContext.Ahorros.Remove(ahorroEntity);
            _DbContext.SaveChanges();
        }
        public void Update(AhorroModel ahorro, int id)
        {
            AhorroEntity ahorroEntity = GetById(id);
            {
                ahorroEntity.Divisa = ahorro.Divisa;
                ahorroEntity.Users = ahorro.Users;
                ahorroEntity.Objetivos = ahorro.Objetivos;


                ahorroEntity.Moneda_id = ahorro.Moneda_id;
                ahorroEntity.User_id = ahorro.User_id;
                ahorroEntity.Objetivo_id = ahorro.Objetivo_id;


                ahorroEntity.ValorAhorro = ahorro.ValorAhorro;
            }
            _DbContext.Ahorros.Update(ahorroEntity);
            _DbContext.SaveChanges();
        }
        public List<AhorroEntity> GetAll()
        {
            return _DbContext.Ahorros.ToList();
        }
        public AhorroEntity GetById(int id)
        {
            return _DbContext.Ahorros.Find(id);
        }
    }
}
