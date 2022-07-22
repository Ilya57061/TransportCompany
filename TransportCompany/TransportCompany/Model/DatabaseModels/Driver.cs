
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportCompany.Model.DatabaseModels
{
    [Table ("Drivers")]
    public class Driver : Employee
    {
        public List<Car> Cars { get; set; }
    }
}
