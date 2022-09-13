using Microsoft.AspNetCore.Mvc.Rendering;
using NetCoreUnityIOC.Models.Entities;
using System.Collections.Generic;

namespace NetCoreUnityIOC.Models.ViewModels
{
    public class ProductCreateViewModel
    {
        public Product Product { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Suppliers { get; set; }
    }
}
