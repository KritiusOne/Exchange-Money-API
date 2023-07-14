using Exchange_Money_API.Data;
using Exchange_Money_API.Models;

namespace Exchange_Money_API.Services
{
    public class MonedaService : IService<MonedaEntity, MonedaModel>
    {
        private readonly ExchangeMoneyContext _DbContext;
        public MonedaService(ExchangeMoneyContext context)
        {
            _DbContext = context;
        }
        public void Create(MonedaModel moneda)
        {
            MonedaEntity monedaEntity = new MonedaEntity();
            {
                monedaEntity.NameMoneda = moneda.NameMoneda;
                monedaEntity.Egresos = moneda.Egresos;
                monedaEntity.Ingresos = moneda.Ingresos;
            }
            _DbContext.Divisas.Add(monedaEntity);
            _DbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            MonedaEntity moneda = GetById(id);
            _DbContext.Divisas.Remove(moneda);
            _DbContext.SaveChanges();
        }
        public void Update(MonedaModel moneda, int id)
        {
            MonedaEntity monedaEntity = GetById(id);
            {
                monedaEntity.NameMoneda = moneda.NameMoneda;
                monedaEntity.Egresos = moneda.Egresos;
                monedaEntity.Ingresos = moneda.Ingresos;
            }
            _DbContext.Divisas.Update(monedaEntity);
            _DbContext.SaveChanges();
        }
        public List<MonedaEntity> GetAll()
        {
            return _DbContext.Divisas.ToList();
        }
        public MonedaEntity GetById(int id)
        {
            return _DbContext.Divisas.Find(id);
        }
    }
}
