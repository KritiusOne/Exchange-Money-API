using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange_Money_API.Models
{
    public class AhorroModel
    {
        public decimal ValorAhorro { get; set; }
        public int Moneda_id { get; set; }
        [ForeignKey("Moneda_id")]
        public virtual MonedaEntity? Divisa { get; set; }
        public int Objetivo_id { get; set; }
        [ForeignKey("Objetivo_id")]
        public virtual ObjetivoAhorroEntity? Objetivos { get; set; }
        public int User_id { get; set; }
        [ForeignKey("User_id")]
        public virtual UserEntity? Users { get; set; }
    }
}
