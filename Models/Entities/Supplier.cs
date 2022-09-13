using System.Collections.Generic;

namespace NetCoreUnityIOC.Models.Entities
{
    public class Supplier
    {

        public int Id { get; set; }
        public string CompanyName { get; set; }
        // 1 supplierda => n ürün olabilir
        public ICollection<Product> MyProperty { get; set; }
    }
}
