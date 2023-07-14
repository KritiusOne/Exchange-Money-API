using Exchange_Money_API.Data;
using Exchange_Money_API.Models;

namespace Exchange_Money_API.Services
{
    public class TipoSellerService : IService<TipoSellerEntity, TipoSellerModel>
    {

        private readonly ExchangeMoneyContext _DbContext;
        public TipoSellerService(ExchangeMoneyContext context)
        {
            _DbContext = context;
        }
        public void Create(TipoSellerModel tipoSeller)
        {
            TipoSellerEntity tipoSellerEntity = new TipoSellerEntity();
            {
                tipoSellerEntity.NameTipoSeller = tipoSeller.NameTipoSeller;
                tipoSellerEntity.Sellers = tipoSeller.Sellers;
            }
            _DbContext.TipoSellers.Add(tipoSellerEntity);
            _DbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            TipoSellerEntity tipoSeller = GetById(id);
            _DbContext.TipoSellers.Remove(tipoSeller);
            _DbContext.SaveChanges();
        }
        public void Update(TipoSellerModel tipoSeller, int id)
        {
            TipoSellerEntity tipoSellerEntity = GetById(id);
            {
                tipoSellerEntity.NameTipoSeller = tipoSeller.NameTipoSeller;
                tipoSellerEntity.Sellers = tipoSeller.Sellers;
            }
            _DbContext.TipoSellers.Update(tipoSellerEntity);
            _DbContext.SaveChanges();
        }
        public List<TipoSellerEntity> GetAll()
        {
            return _DbContext.TipoSellers.ToList();
        }
        public TipoSellerEntity GetById(int id)
        {
            return _DbContext.TipoSellers.Find(id);
        }
    }
}

