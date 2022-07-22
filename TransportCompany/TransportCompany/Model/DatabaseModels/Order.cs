using System.ComponentModel.DataAnnotations.Schema;

namespace TransportCompany.Model.DatabaseModels
{
    [Table("Orders")]
    public class Order
    {
        public int Id { get; set; }
        public ushort Price { get; set; }
        public int? CarId { get; set; }
        public Car Car { get; set; }
        public int? AddressId { get; set; }
        public Address Address { get; set; }
        public int? ClientId { get; set; }
        public Client Client { get; set; }


    }
}
