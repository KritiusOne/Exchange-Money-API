namespace Exchange_Money_API.Models
{
    public class AcreedorModel
    {
        public string Name { get; set; }
        public virtual ICollection<DeudaEntity>? Deudas { get; set; }
    }
}
