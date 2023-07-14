using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange_Money_API.Models
{
    public class SellersModel
    {
        public string NameSeller { get; set; }
        public int TipoSeller_id { get; set; }
        [ForeignKey("TipoSeller_id")]
        public virtual TipoSellerEntity? TipoSellers { get; set; }
        public string City { get; set; }
        public virtual ICollection<EgresoEntity>? Egresos { get; set; }
    }
}
