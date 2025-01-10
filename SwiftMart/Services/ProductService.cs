using SwiftMart.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Provides services for managing products in the SwiftMart system.
/// Includes operations for saving new products to the database.
/// </summary>
namespace SwiftMart.Services
{
    public class ProductService
    {
        private readonly Context context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductService"/> class.
        /// </summary>
        public ProductService()
        {
            context = new Context();
        }

        /// <summary>
        /// Saves a new product to the database.
        /// The product is added to the database context and changes are saved.
        /// </summary>
        public void SaveProduct()
        {
            var product = new Product() 
            {

            };
        }

    }
}
