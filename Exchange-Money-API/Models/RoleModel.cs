using System.ComponentModel.DataAnnotations;

namespace Exchange_Money_API.Models
{
    public class RoleModel
    {
        [StringLength(255)]
        public string Role { get; set; }
        public virtual ICollection<UserEntity>? Users { get; set; }
    }
}
