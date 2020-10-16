using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational_Patterns.Singleton.Models
{
    class DatabaseConnection
    {
        private static DatabaseConnection instance;

        private DatabaseConnection()
        {
            Console.WriteLine("DatabaseConnection created"); // Singleton Logger could be used
        }

        public static DatabaseConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConnection();
            }

            return instance;
        }

        public List<string> GetBrands()
        {
            List<string> lst = new List<string>();

            lst.Add("CocaCola");
            lst.Add("Watsons");
            lst.Add("P&G");

            return lst;
        }
    }
}
