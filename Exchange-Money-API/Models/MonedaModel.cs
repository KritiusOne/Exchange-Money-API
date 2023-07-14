namespace Exchange_Money_API.Models
{
    public class MonedaModel
    {
        public string NameMoneda { get; set; }
        public virtual ICollection<IngresoEntity>? Ingresos { get; set; }
        public virtual ICollection<EgresoEntity>? Egresos { get; set; }
    }
}
