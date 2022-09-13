namespace NetCoreUnityIOC.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }

        // 1 ürünün => 1 category'si olur
        public Category Category { get; set; }

        // 1 ürünün => 1 tedarikçisi olur
        public Supplier Supplier { get; set; }
    }
}
