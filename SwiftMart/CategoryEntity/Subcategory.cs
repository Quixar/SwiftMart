using SwiftMart.CategoryEntity;
using SwiftMart.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMartCRM.CategoryEntity
{
    public class Subcategory
    {
        public int Id { get; set; } // Уникальный идентификатор подкатегории
        public string Name { get; set; } = string.Empty; // Название подкатегории
        public int CategoryId { get; set; } // Внешний ключ на категорию
        public Category? Category { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
