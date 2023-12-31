﻿using System.ComponentModel.DataAnnotations;

namespace Exchange_Money_API.Models
{
    public class TipoSellerEntity
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string NameTipoSeller { get; set; }
        public virtual ICollection<SellersEntity>? Sellers { get; set; }
    }
}
