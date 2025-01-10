
/// <summary>
/// Represents the sales statistics for the SwiftMart system.
/// Includes information about popular products and total sales.
/// </summary>
namespace SwiftMart.StatisticEntities
{
    public class SalesStatistics
    {

        /// <summary>
        /// Gets or sets the list of popular products based on sales performance.
        /// </summary>
        public List<Product> PopularProducts { get; set; }

        /// <summary>
        /// Gets or sets the total number of sales made.
        /// </summary>
        public int TotalSales { get; set; }

        /// <summary>
        /// Generates a sales report based on the current statistics.
        /// The implementation for generating the report can be added later.
        /// </summary>
        public void GenerateReport()
        {

        }
    }
}
