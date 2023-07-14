using Exchange_Money_API.Data;
using Exchange_Money_API.Models;

namespace Exchange_Money_API.Services
{
    public class TipoService : IService<TipoEntity, TipoModel>
    {

        private readonly ExchangeMoneyContext _DbContext;
        public TipoService(ExchangeMoneyContext context)
        {
            _DbContext = context;
        }
        public void Create(TipoModel tipo)
        {
            TipoEntity tipoEntity = new TipoEntity();
            {
                tipoEntity.NameTipo = tipo.NameTipo;
                tipoEntity.TipoTransaccion = tipo.TipoTransaccion;
                tipoEntity.Descripcion = tipo.Descripcion;
                tipoEntity.Egresos = tipo.Egresos;
                tipoEntity.Ingresos = tipo.Ingresos;
            }
            _DbContext.Tipos.Add(tipoEntity);
            _DbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            TipoEntity tipo = GetById(id);
            _DbContext.Tipos.Remove(tipo);
            _DbContext.SaveChanges();
        }
        public void Update(TipoModel tipo, int id)
        {
            TipoEntity tipoEntity = GetById(id);
            {
                tipoEntity.NameTipo = tipo.NameTipo;
                tipoEntity.TipoTransaccion = tipo.TipoTransaccion;
                tipoEntity.Descripcion = tipo.Descripcion;
                tipoEntity.Egresos = tipo.Egresos;
                tipoEntity.Ingresos = tipo.Ingresos;
            }
            _DbContext.Tipos.Update(tipoEntity);
            _DbContext.SaveChanges();
        }
        public List<TipoEntity> GetAll()
        {
            return _DbContext.Tipos.ToList();
        }
        public TipoEntity GetById(int id)
        {
            return _DbContext.Tipos.Find(id);
        }
    }
}

