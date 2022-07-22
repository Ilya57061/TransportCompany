
using System.ComponentModel.DataAnnotations.Schema;


namespace TransportCompany.Model.DatabaseModels
{
    [Table("Addresses")]
    public class Address
    {
      
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public ushort Index { get; set; }
        public List<Person> Persons { get; set; }
        public Office Office { get; set; }
        public Warehouse Warehouse { get; set; }
        public List<Order> Orders { get; set; }
    }
}
