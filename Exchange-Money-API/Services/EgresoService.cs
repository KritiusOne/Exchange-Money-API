using Exchange_Money_API.Data;
using Exchange_Money_API.Models;

namespace Exchange_Money_API.Services
{
    public class EgresoService : IService<EgresoEntity, EgresoModel>
    {
        private readonly ExchangeMoneyContext _context;
        public EgresoService(ExchangeMoneyContext context)
        {
            _context = context;
        }

        public void Create(EgresoModel egreso)
        {
            EgresoEntity egresoEntity = new EgresoEntity();
            {
                egreso.User_id = egreso.User_id;
                egresoEntity.Name = egreso.Name;
                egresoEntity.Tipo_id = egreso.Tipo_id;
                egresoEntity.Moneda_id = egreso.Moneda_id;
                egreso.Seller_id = egreso.Seller_id;
                egreso.ValorEgreso = egreso.ValorEgreso;
                egresoEntity.Fecha = egreso.Fecha;
                egresoEntity.Divisa = egreso.Divisa;
                egresoEntity.User = egreso.User;
                egresoEntity.Divisa = egreso.Divisa;
            }
            _context.Egresos.Add(egresoEntity);
            _context.SaveChanges();
        }
        public EgresoEntity GetById(int id) {
            return _context.Egresos.Find(id);
        }
        public List<EgresoEntity> GetAll() {
            return _context.Egresos.ToList();
        }
        public void Update(EgresoModel egreso, int id) {
            EgresoEntity egresoEntity = GetById(id);
            {
                egreso.User_id = egreso.User_id;
                egresoEntity.Name = egreso.Name;
                egresoEntity.Tipo_id = egreso.Tipo_id;
                egresoEntity.Moneda_id = egreso.Moneda_id;
                egreso.Seller_id = egreso.Seller_id;
                egreso.ValorEgreso = egreso.ValorEgreso;
                egresoEntity.Fecha = egreso.Fecha;
                egresoEntity.Divisa = egreso.Divisa;
                egresoEntity.User = egreso.User;
                egresoEntity.Divisa = egreso.Divisa;
            }
            _context.Egresos.Update(egresoEntity);
            _context.SaveChanges();
        }
        public void Delete(int id) {
            EgresoEntity egreso = GetById(id);
            _context.Egresos.Remove(egreso);
            _context.SaveChanges();
        }
    }
}
