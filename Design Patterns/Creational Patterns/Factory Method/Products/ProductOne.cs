using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Patterns.Factory_Method.Products
{
    class ProductOne : Product
    {
        public string GetName()
        {
            return "Product One";
        }

        public int GetPrice()
        {
            return 11;
        }
    }
}
