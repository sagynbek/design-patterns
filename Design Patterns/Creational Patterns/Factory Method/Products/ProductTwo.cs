using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Patterns.Factory_Method.Products
{
    class ProductTwo : Product
    {
        public string GetName()
        {
            return "Product Two";
        }

        public int GetPrice()
        {
            return 22;
        }
    }
}
