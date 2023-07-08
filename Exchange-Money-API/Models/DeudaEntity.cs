using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange_Money_API.Models
{
    public class DeudaEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int User_id { get; set; }
        [ForeignKey("User_id")]
        public virtual UserEntity Users { get; set; }
        [StringLength(255)]
        public string name { get; set; }
        public DateTime Fecha { get; set; }
        [Column(TypeName = "decimal(12,4)")]

        public decimal ValorDeuda { get; set; }
        [StringLength(255)]
        public string Estado { get; set; } // false es que ya esta paga, true es que todavia se debe pagar

        public int Acreedor_id { get; set; }
        [ForeignKey("Acreedor_id")]
        public virtual AcreedorEntity Acreedores { get; set; }
    }
}
