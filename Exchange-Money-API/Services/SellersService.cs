using Exchange_Money_API.Data;
using Exchange_Money_API.Models;

namespace Exchange_Money_API.Services
{
    public class SellersService : IService<SellersEntity, SellersModel>
    {
        private readonly ExchangeMoneyContext _DbContext;
        public SellersService(ExchangeMoneyContext context)
        {
            _DbContext = context;
        }
        public void Create(SellersModel sellers)
        {
            SellersEntity sellersEntity = new SellersEntity();
            {
                sellersEntity.NameSeller = sellers.NameSeller;
                sellersEntity.TipoSeller_id = sellers.TipoSeller_id;
                sellersEntity.TipoSellers = sellers.TipoSellers;
                sellersEntity.City = sellers.City;
                sellersEntity.Egresos = sellers.Egresos;
            }
            _DbContext.Sellers.Add(sellersEntity);
            _DbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            SellersEntity sellers = GetById(id);
            _DbContext.Sellers.Remove(sellers);
            _DbContext.SaveChanges();
        }
        public void Update(SellersModel sellers, int id)
        {
            SellersEntity sellersEntity = GetById(id);
            {
                sellersEntity.NameSeller = sellers.NameSeller;
                sellersEntity.TipoSeller_id = sellers.TipoSeller_id;
                sellersEntity.TipoSellers = sellers.TipoSellers;
                sellersEntity.City = sellers.City;
                sellersEntity.Egresos = sellers.Egresos;
            }
            _DbContext.Sellers.Update(sellersEntity);
            _DbContext.SaveChanges();
        }
        public List<SellersEntity> GetAll()
        {
            return _DbContext.Sellers.ToList();
        }
        public SellersEntity GetById(int id)
        {
            return _DbContext.Sellers.Find(id);
        }
    }
}
