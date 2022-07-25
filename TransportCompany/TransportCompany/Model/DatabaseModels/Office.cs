using System.ComponentModel.DataAnnotations.Schema;

namespace TransportCompany.Model.DatabaseModels
{
    [Table("Offices")]
    public class Office
    {
        public int Id { get; set; }
        public int? PhoneId { get; set; }
        public Phone Phone { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
