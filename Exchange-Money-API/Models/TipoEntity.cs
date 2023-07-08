using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange_Money_API.Models
{
    public class TipoEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(255)]
        public string NameTipo { get; set; }
        public bool TipoTransaccion { get; set; } //SI es false, es egreso, si es true, ingreso
        [StringLength(255)]
        public string Descripcion { get; set; }
        public virtual ICollection<EgresoEntity> Egresos { get; set; }
        public virtual ICollection<IngresoEntity> Ingresos { get; set; }
    }
}
