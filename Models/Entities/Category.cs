using System.Collections;
using System.Collections.Generic;

namespace NetCoreUnityIOC.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // 1 kategoride =>  n product

        public ICollection<Product> MyProperty { get; set; }
    }
}
