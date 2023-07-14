namespace Exchange_Money_API.Models
{
    public class ObjetivoAhorroModel
    {
        public string Description { get; set; }
        public virtual ICollection<AhorroEntity>? Ahorros { get; set; }
    }
}
