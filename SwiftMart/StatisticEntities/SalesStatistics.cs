using SwiftMart.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.StatisticEntities
{
    public class SalesStatistics
    {
        public List<Product> PopularProducts { get; set; }

        public int TotalSales { get; set; }

        public void GenerateReport()
        {

        }
    }
}
