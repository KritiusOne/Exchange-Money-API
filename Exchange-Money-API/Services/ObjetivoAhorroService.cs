using Exchange_Money_API.Data;
using Exchange_Money_API.Models;

namespace Exchange_Money_API.Services
{
    public class ObjetivoAhorroService : IService<ObjetivoAhorroEntity, ObjetivoAhorroModel>
    {
        private readonly ExchangeMoneyContext _DbContext;
        public ObjetivoAhorroService(ExchangeMoneyContext context)
        {
            _DbContext = context;
        }
        public void Create(ObjetivoAhorroModel objetivoAhorro)
        {
            ObjetivoAhorroEntity objetivoAhorroEntity = new ObjetivoAhorroEntity();
            {
                objetivoAhorroEntity.Description = objetivoAhorro.Description;
                objetivoAhorroEntity.Ahorros = objetivoAhorro.Ahorros;
            }
            _DbContext.Objetivos.Add(objetivoAhorroEntity);
            _DbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            ObjetivoAhorroEntity objetivoAhorro = GetById(id);
            _DbContext.Objetivos.Remove(objetivoAhorro);
            _DbContext.SaveChanges();
        }
        public void Update(ObjetivoAhorroModel objetivoAhorro, int id)
        {
            ObjetivoAhorroEntity objetivoAhorroEntity = GetById(id);
            {
                objetivoAhorroEntity.Description = objetivoAhorro.Description;
                objetivoAhorroEntity.Ahorros = objetivoAhorro.Ahorros;
            }
            _DbContext.Objetivos.Update(objetivoAhorroEntity);
            _DbContext.SaveChanges();
        }
        public List<ObjetivoAhorroEntity> GetAll()
        {
            return _DbContext.Objetivos.ToList();
        }
        public ObjetivoAhorroEntity GetById(int id)
        {
            return _DbContext.Objetivos.Find(id);
        }
    }
}
