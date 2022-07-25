
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportCompany.Model.DatabaseModels
{
    [Table("Сategories")]
    public class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
