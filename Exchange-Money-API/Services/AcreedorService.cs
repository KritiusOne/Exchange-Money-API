using Exchange_Money_API.Data;
using Exchange_Money_API.Models;

namespace Exchange_Money_API.Services
{
    public class AcreedorService : IService<AcreedorEntity, AcreedorModel>
    {
        private readonly ExchangeMoneyContext _DbContext;
        public AcreedorService(ExchangeMoneyContext context)
        {
            _DbContext = context;
        }
        public void Create(AcreedorModel acreedor)
        {
            AcreedorEntity acreedorEntity = new AcreedorEntity();
            {
                acreedorEntity.Deudas = acreedor.Deudas;
                acreedorEntity.Name = acreedor.Name;
            }
            _DbContext.Acreedores.Add(acreedorEntity);
            _DbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            AcreedorEntity acreedor = GetById(id);
            _DbContext.Acreedores.Remove(acreedor);
            _DbContext.SaveChanges();
        }
        public void Update(AcreedorModel acreedor, int id)
        {
            AcreedorEntity acreedorEntity = GetById(id);
            {
                acreedorEntity.Deudas = acreedor.Deudas;
                acreedorEntity.Name = acreedor.Name;
            }
            _DbContext.Acreedores.Update(acreedorEntity);
            _DbContext.SaveChanges();
        }
        public List<AcreedorEntity> GetAll()
        {
            return _DbContext.Acreedores.ToList();
        }
        public AcreedorEntity GetById(int id)
        {
            return _DbContext.Acreedores.Find(id);
        }
    }
}
