using System.ComponentModel.DataAnnotations.Schema;

namespace TransportCompany.Model.DatabaseModels
{
    [Table ("Products")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ushort Price { get; set; }
        public ushort Count { get; set; }
        public string Description { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
