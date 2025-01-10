using SwiftMart.ProductEntity;
using SwiftMart.StatisticEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a seller on the SwiftMart platform. A seller manages a store, products, and sales statistics.
/// </summary>
namespace SwiftMart.UserEntities
{
    public class Seller
    {

        /// <summary>
        /// Gets or sets the store managed by the seller.
        /// </summary>
        public Store Store { get; set; }

        /// <summary>
        /// Gets or sets the list of products owned by the seller.
        /// </summary>
        public List<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the sales statistics for the seller, including popular products and total sales.
        /// </summary>
        public SalesStatistics Statistics { get; set; }

        /// <summary>
        /// Manages the seller's store, including adding, removing, or updating products.
        /// </summary>
        public void ManageStore()
        {

        }
    }
}
