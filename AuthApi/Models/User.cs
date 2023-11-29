using System.ComponentModel.DataAnnotations.Schema;

namespace AuthApi.Models
{
    [Table("USERS")]
    public class User
    {
        public long Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [Column("phone_number")]
        public long PhoneNumber { get; set; }

        [Column("address_id")]
        public long AddressId { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        public List<UserRole> UserRoles { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        [Column("created_by")]
        public string CreatedBy { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("modified_by")]
        public string ModifiedBy { get; set; }

        [Column("modified_at")]
        public DateTime ModifiedAt { get; set; }

        [Column("deleted_by")]
        public string DeletedBy { get; set; }

        [Column("deleted_at")]
        public DateTime DeletedAt { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

    }
}
