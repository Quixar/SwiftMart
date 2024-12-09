using System;
using System.Collections.Generic;
using SwiftMart.ProductEntities;
namespace SwiftMart.SalesStatistic
{
    internal class SalesStatistics
    {
        public List<Product> PopularProducts { get; set; } 
        
        public int TotalSales { get; set; } 

        public void GenerateReport()
        {

        }
    }
}