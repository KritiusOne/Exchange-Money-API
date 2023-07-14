using Exchange_Money_API.Data;
using Exchange_Money_API.Models;

namespace Exchange_Money_API.Services
{
    public class IngresoService : IService<IngresoEntity, IngresoModel>
    {
        private readonly ExchangeMoneyContext _DbContext;
        public IngresoService(ExchangeMoneyContext context) { 
            _DbContext = context;
        }
        public void Create(IngresoModel ingreso)
        {
            IngresoEntity ingresoEntity = new IngresoEntity();
            {
                ingresoEntity.FechaIngreso = ingreso.FechaIngreso;
                ingresoEntity.ValorIngreso = ingreso.ValorIngreso;
                ingresoEntity.Tipo_id = ingreso.Tipo_id;
                ingresoEntity.User_id = ingreso.Tipo_id;
                ingresoEntity.Moneda_id = ingreso.Moneda_id;
                ingresoEntity.Users = ingreso.Users;
                ingresoEntity.Tipos = ingreso.Tipos;
                ingresoEntity.Divisas = ingreso.Divisas;
            }
            _DbContext.Ingresos.Add(ingresoEntity);
            _DbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            IngresoEntity ingreso = GetById(id);
            _DbContext.Remove(ingreso);
            _DbContext.SaveChanges();
        }
        public void Update(IngresoModel ingreso, int id)
        {
            IngresoEntity ingresoEntity = new IngresoEntity();
            {
                ingresoEntity.FechaIngreso = ingreso.FechaIngreso;
                ingresoEntity.ValorIngreso = ingreso.ValorIngreso;
                ingresoEntity.Tipo_id = ingreso.Tipo_id;
                ingresoEntity.User_id = ingreso.Tipo_id;
                ingresoEntity.Moneda_id = ingreso.Moneda_id;
                ingresoEntity.Users = ingreso.Users;
                ingresoEntity.Tipos = ingreso.Tipos;
                ingresoEntity.Divisas = ingreso.Divisas;
            }
            _DbContext.Ingresos.Update(ingresoEntity);
            _DbContext.SaveChanges();
        }
        public List<IngresoEntity> GetAll()
        {
            return _DbContext.Ingresos.ToList();
        }
        public IngresoEntity GetById(int id)
        {
            return _DbContext.Ingresos.Find(id);
        }
    }
}
