using AutoRental.Models.Models.Role;
using System.ComponentModel.DataAnnotations;

namespace AutoRental.Models.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        public DateOnly? UserDOB { get; set; }

        [MaxLength(11)]
        public string PhoneNumber { get; set; }

        [MaxLength(255)]
        public string AvatarUrl { get; set; }

        [MaxLength(10)]
        public string Gender { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        [MaxLength(255)]
        public string NormalizedUserName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string NormalizedEmail { get; set; }

        [Required]
        public bool EmailVerified { get; set; }

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }

        public DateTime? LockoutEnd { get; set; }

        [Required]
        public bool LockoutEnabled { get; set; }

        [Required]
        public int AccessFailedCount { get; set; }

        // Navigation property
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}