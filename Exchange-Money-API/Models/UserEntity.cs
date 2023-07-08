using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Exchange_Money_API.Models
{
    public class UserEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(255)]
        public string UserName { get; set; }
        public int Role_id { get; set; }

        [ForeignKey("Role_id")]
        public virtual RoleEntity Roles { get; set; }
        public virtual ICollection<EgresoEntity> Egresos { get; set; }
        public virtual ICollection<IngresoEntity> Ingresos { get; set; }
        public virtual ICollection<AhorroEntity> Ahorros { get; set; }
    }
}
