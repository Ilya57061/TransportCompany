using System.ComponentModel.DataAnnotations.Schema;

namespace TransportCompany.Model.DatabaseModels
{
    [Table ("Persons")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AddressId{get;set;}
        public Address Address{ get; set; }
        public int? PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}
