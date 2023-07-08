using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange_Money_API.Models
{
    public class EgresoEntity
    {
        public EgresoEntity() { }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        //Llave foranea para el tipo del egreso
        public int Tipo_id { get; set; }
        [ForeignKey("Tipo_id")]
        public virtual TipoEntity Tipos { get; set; }
        [Column(TypeName = "decimal(12,4)")]


        public decimal ValorEgreso { get; set; }
        public DateTime Fecha { get; set; }

        //Llave foranea para la tabla vendedores
        public int Seller_id { get; set; }
        [ForeignKey("Seller_id")]
        public virtual SellersEntity Sellers { get; set; }

        //Llave foranea para la tabla users
        public int User_id { get; set; }
        [ForeignKey("User_id")]
        public virtual UserEntity User { get; set; }
        public int Moneda_id { get; set; }
        [ForeignKey("Moneda_id")]
        public virtual MonedaEntity Divisa { get; set; }
    }
}
