using System.ComponentModel.DataAnnotations;

namespace AutoRental.Models.Models.Role
{
    public class Role
    {
        [Key]
        public Guid RoleId { get; set; }

        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; }

        [Required]
        [MaxLength(50)]
        public string NormalizedName { get; set; }

        // Navigation property 
        public virtual ICollection<UserRole> Roles { get; set; }

    }
}
