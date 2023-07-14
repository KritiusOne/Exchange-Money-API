using Exchange_Money_API.Data;
using Exchange_Money_API.Models;

namespace Exchange_Money_API.Services
{
    public class DeudaService : IService<DeudaEntity, DeudaModel>
    {
        private readonly ExchangeMoneyContext _context;
        public DeudaService(ExchangeMoneyContext context)
        {
            _context = context;
        }

        public void Create(DeudaModel deuda)
        {
            DeudaEntity deudaEntity = new DeudaEntity();
            {
                deudaEntity.Acreedores = deuda.Acreedores;
                deudaEntity.Users = deuda.Users;

                deudaEntity.Acreedor_id = deuda.Acreedor_id;
                deudaEntity.User_id = deuda.User_id;

                deudaEntity.Estado = deuda.Estado;
                deudaEntity.ValorDeuda = deuda.ValorDeuda;
                deudaEntity.name = deuda.name;
                deudaEntity.Fecha = deuda.Fecha;
            }
            _context.Deudas.Add(deudaEntity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            DeudaEntity deudaEntity = GetById(id);
            _context.Deudas.Remove(deudaEntity);
            _context.SaveChanges();
        }
        public void Update(DeudaModel deuda, int id)
        {
            DeudaEntity deudaEntity = GetById(id);
            {
                deudaEntity.Acreedores = deuda.Acreedores;
                deudaEntity.Users = deuda.Users;

                deudaEntity.Acreedor_id = deuda.Acreedor_id;
                deudaEntity.User_id = deuda.User_id;

                deudaEntity.Estado = deuda.Estado;
                deudaEntity.ValorDeuda = deuda.ValorDeuda;
                deudaEntity.name = deuda.name;
                deudaEntity.Fecha = deuda.Fecha;
            }
            _context.Deudas.Update(deudaEntity);
            _context.SaveChanges();
        }
        public List<DeudaEntity> GetAll()
        {
            return _context.Deudas.ToList();
        }
        public DeudaEntity GetById(int id)
        {
            return _context.Deudas.Find(id);
        }
    }    
}