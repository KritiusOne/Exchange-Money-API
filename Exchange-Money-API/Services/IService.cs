namespace Exchange_Money_API.Services
{
    public interface IService<T,B>
    {
        void Create(B Model);
        void Delete(int id);
        void Update(B Model, int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
