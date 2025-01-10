using SwiftMart.CategoryEntity;
using SwiftMart.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a product subcategory within the SwiftMart system.
/// A subcategory provides a more specific classification of products within a larger category.
/// </summary>
namespace SwiftMartCRM.CategoryEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the subcategory.
    /// Serves as the primary key in the database.
    /// </summary>
    public class Subcategory
    {
        /// <summary>
        /// Gets or sets the name of the subcategory.
        /// This property represents the label for the subcategory.
        /// </summary>
        public int Id { get; set; } // Уникальный идентификатор подкатегории

        /// <summary>
        /// Gets or sets the name of the subcategory.
        /// This property represents the label for the subcategory.
        /// </summary>
        public string Name { get; set; } = string.Empty; // Название подкатегории

        /// <summary>
        /// Gets or sets the identifier for the category to which this subcategory belongs.
        /// This is a foreign key that links the subcategory to a parent category.
        /// </summary>
        public int CategoryId { get; set; } // Внешний ключ на категорию

        /// <summary>
        /// Gets or sets the category associated with this subcategory.
        /// This navigation property links the subcategory to the parent category entity.
        /// </summary>
        public Category? Category { get; set; }

        /// <summary>
        /// Gets or sets the collection of products associated with this subcategory.
        /// This property contains all the products that belong to this specific subcategory.
        /// </summary>
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
