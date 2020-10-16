using Design_Patterns.Creational_Patterns.Singleton.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Patterns.Singleton
{
    class Singleton
    {
        public Singleton()
        {
            this.Run();
        }

        private void Run()
        {
            this.GetBrandsOne();
            this.GetBrandsTwo();
            this.GetBrandsOne();
            this.GetBrandsTwo();
            this.GetBrandsOne();
            this.GetBrandsTwo();

            Console.WriteLine("Note: If you see only 1 time DatabaseConnection creation message, then you are good to go");
        }

        private void GetBrandsOne()
        {
            DatabaseConnection dbConnection = DatabaseConnection.GetInstance();
            dbConnection.GetBrands();
        }
        private void GetBrandsTwo()
        {
            DatabaseConnection dbConnection = DatabaseConnection.GetInstance();
            dbConnection.GetBrands();
        }
    }
}
