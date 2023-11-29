using System.ComponentModel.DataAnnotations.Schema;

namespace AuthApi.Models
{
    [Table("ROLES")]
    public class Role
    {
        public long Id { get; set; }
        public string name { get; set; }
        public List<UserRole> UserRoles { get; set; }

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
