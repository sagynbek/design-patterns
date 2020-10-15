using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Patterns.Factory_Method.Products
{
    interface Product
    {
        public int GetPrice();
        public string GetName();
    }
}
