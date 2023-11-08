using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KiemtraGiuaKy.Models
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }

        [Required]
        public string RoleName { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
