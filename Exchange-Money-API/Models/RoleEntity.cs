using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange_Money_API.Models
{
    public class RoleEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(255)]
        public string Role { get; set; }
        public virtual ICollection<UserEntity> Users { get; set; }
    }
}
