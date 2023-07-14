using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange_Money_API.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public int Role_id { get; set; }
        [ForeignKey("Role_id")]
        public virtual RoleEntity? Roles { get; set; }
        public virtual ICollection<EgresoEntity>? Egresos { get; set; }
        public virtual ICollection<IngresoEntity>? Ingresos { get; set; }
        public virtual ICollection<AhorroEntity>? Ahorros { get; set; }
    }
}
