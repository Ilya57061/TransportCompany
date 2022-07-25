
using System.ComponentModel.DataAnnotations.Schema;



namespace TransportCompany.Model.DatabaseModels
{
    [Table ("Suppliers")]
    public class Supplier:Person
    {
        public List<Product> Products { get; set; }
    }
}
