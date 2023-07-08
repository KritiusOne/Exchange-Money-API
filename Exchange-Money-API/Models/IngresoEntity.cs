using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange_Money_API.Models
{
    public class IngresoEntity
    {
        public IngresoEntity() { }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Lo hace autoincremental
        public int Id { get; set; }
        public int User_id { get; set; }
        [ForeignKey("User_id")]
        public virtual UserEntity Users { get; set; }

        [Column(TypeName = "decimal(12,4)")]
        public decimal ValorIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }

        public int Tipo_id { get; set; }
        [ForeignKey("Tipo_id")]
        public virtual TipoEntity Tipos { get; set; }
        public int Moneda_id { get; set; }
        [ForeignKey("Moneda_id")]

        public virtual MonedaEntity Divisas { get; set; }
    }
}
