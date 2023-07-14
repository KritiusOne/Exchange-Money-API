using System.ComponentModel.DataAnnotations;

namespace Exchange_Money_API.Models
{
    public class TipoModel
    {
        [StringLength(255)]
        public string NameTipo { get; set; }
        public bool TipoTransaccion { get; set; } //SI es false, es egreso, si es true, ingreso
        [StringLength(255)]
        public string Descripcion { get; set; }
        public virtual ICollection<EgresoEntity>? Egresos { get; set; }
        public virtual ICollection<IngresoEntity>? Ingresos { get; set; }
    }
}
