using SwiftMartCRM.CategoryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a product category within the SwiftMart system.
/// A category groups related products and may contain a collection of subcategories.
/// </summary>
namespace SwiftMart.CategoryEntity
{
    public class Category
    {

        /// <summary>
        /// Gets or sets the unique identifier for the category.
        /// Serves as the primary key in the database.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the category.
        /// This property represents the primary label for the category.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of subcategories associated with this category.
        /// A subcategory provides more specific grouping within the main category.
        /// </summary>
        public ICollection<Subcategory> Subcategories { get; set; } = new List<Subcategory>();
    }
}
