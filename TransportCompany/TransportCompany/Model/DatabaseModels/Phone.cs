using System.ComponentModel.DataAnnotations.Schema;

namespace TransportCompany.Model.DatabaseModels
{
    [Table ("Phones")]
    public class Phone
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public List<Person> Persons { get; set; }
        public List<Office> Offices { get; set; }
    }
}
