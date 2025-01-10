using SwiftMartCRM.CategoryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.CategoryEntity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Subcategory> Subcategories { get; set; } = new List<Subcategory>();
    }
}
