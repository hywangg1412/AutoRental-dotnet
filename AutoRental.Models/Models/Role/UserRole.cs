namespace AutoRental.Models.Models.Role
{
    public class UserRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        // Navigation property
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
