using System.ComponentModel.DataAnnotations.Schema;

namespace TransportCompany.Model.DatabaseModels
{
    [Table("Managers")]
    public class Manager:Person
    {
        public string Department { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
