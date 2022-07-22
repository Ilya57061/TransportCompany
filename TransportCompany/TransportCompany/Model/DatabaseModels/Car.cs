
using System.ComponentModel.DataAnnotations.Schema;


namespace TransportCompany.Model.DatabaseModels
{
    [Table ("Cars")]
    public class Car
    {
        public int Id { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Order> Orders { get; set; }

    }
}
