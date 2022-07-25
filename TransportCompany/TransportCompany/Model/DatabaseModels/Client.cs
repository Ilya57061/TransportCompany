
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportCompany.Model.DatabaseModels
{
    [Table("Clients")]
    public class Client:Person
    {
        public List<Order> Orders { get; set; }
    }
}
