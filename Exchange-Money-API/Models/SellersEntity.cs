using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange_Money_API.Models
{
    public class SellersEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(255)]
        public string NameSeller { get; set; }
        public int TipoSeller_id { get; set; }
        [ForeignKey("TipoSeller_id")]
        public virtual TipoSellerEntity? TipoSellers { get; set; }
        public string City { get; set; }
        public virtual ICollection<EgresoEntity>? Egresos{ get; set; }
    }
}
