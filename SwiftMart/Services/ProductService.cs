using SwiftMart.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Services
{
    public class ProductService
    {
        private readonly Context context;

        public ProductService()
        {
            context = new Context();
        }

        public void SaveProduct()
        {
            var product = new Product() 
            {

            };
        }

    }
}
