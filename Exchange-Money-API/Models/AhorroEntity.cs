using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange_Money_API.Models
{
    public class AhorroEntity
    {
        public AhorroEntity() { }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        [Column(TypeName = "decimal(12,4)")]
        public decimal ValorAhorro { get; set; }
        public int Moneda_id { get; set; }
        [ForeignKey("Moneda_id")]
        public virtual MonedaEntity Divisa { get; set; }
        public int Objetivo_id { get; set; }
        [ForeignKey("Objetivo_id")]
        public virtual ObjetivoAhorroEntity Objetivos { get; set; }
        public int User_id { get; set; }
        [ForeignKey("User_id")]
        public virtual UserEntity Users { get; set; }
    }
}
