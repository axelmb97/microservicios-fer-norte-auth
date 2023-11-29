using System.ComponentModel.DataAnnotations.Schema;

namespace AuthApi.Models
{
    [Table("ADDRESSES")]
    public class Address
    {
        public long Id { get; set; }
        public string Street { get; set; }

        [Column("address_number")]
        public int AddressNumber { get; set; }

        [Column("zip_code")]
        public string ZipCode { get; set; }
        
        public int Floor { get; set; }
        public string Apartment { get; set; }
    }
}
