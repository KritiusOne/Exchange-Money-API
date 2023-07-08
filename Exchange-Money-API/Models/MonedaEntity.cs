using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange_Money_API.Models
{
    public class MonedaEntity
    {
        public MonedaEntity() { }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(255)]
        public string NameMoneda { get; set; }
        public virtual ICollection<IngresoEntity> Ingresos { get; set; }
        public virtual ICollection<EgresoEntity> Egresos { get; set; }

    }
}
