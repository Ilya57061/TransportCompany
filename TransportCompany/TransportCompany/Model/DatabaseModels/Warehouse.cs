using System.ComponentModel.DataAnnotations.Schema;

namespace TransportCompany.Model.DatabaseModels
{
    [Table("Warehouses")]
    public class Warehouse
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public List<Product> Products { get; set; }
    }
}
