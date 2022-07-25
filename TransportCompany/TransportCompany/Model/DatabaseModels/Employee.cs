
using System.ComponentModel.DataAnnotations.Schema;


namespace TransportCompany.Model.DatabaseModels
{
    [Table("Employees")]
    public class Employee : Person
    {
        public string Post { get; set; }
        public int? ManagerId { get; set; }
        public Manager Manager { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }
    }
}
