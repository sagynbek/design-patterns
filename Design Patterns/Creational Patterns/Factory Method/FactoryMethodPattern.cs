using Design_Patterns.Creational_Patterns.Factory_Method.Application;
using Design_Patterns.Creational_Patterns.Factory_Method.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Patterns.Factory_Method
{
    class FactoryMethodPattern
    {
        private ProductFactory factory;
        public FactoryMethodPattern()
        {
            factory = new ProductFactory();
            this.Run();
        }

        private void Run()
        {
            Product someProduct = factory.CreateProduct("ProductOne");
            Product otherProduct = factory.CreateProduct("ProductTwo");

            Console.WriteLine("Product: '{0}' costs: {1}$", someProduct.GetName(),someProduct.GetPrice());
            Console.WriteLine("Product: '{0}' costs: {1}$", otherProduct.GetName(), otherProduct.GetPrice());
        }
    }
}
