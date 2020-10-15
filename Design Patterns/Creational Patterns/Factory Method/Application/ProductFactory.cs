using Design_Patterns.Creational_Patterns.Factory_Method.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Patterns.Factory_Method.Application
{
    class ProductFactory
    {
        public Product CreateProduct(string type)
        {
            Product product = null;
            if(type == "ProductOne")
            {
                product = new ProductOne();
            }
            else if(type == "ProductTwo")
            {
                product = new ProductTwo();
            }

            return product;
        }
    }
}
