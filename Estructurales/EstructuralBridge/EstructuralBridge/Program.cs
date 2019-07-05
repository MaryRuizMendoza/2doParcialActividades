using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuralBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customers = new Customers("Monterrey");
            customers.Data = new CustomersData();
            
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Manolo Sanchez");

            customers.ShowAll();
            Console.ReadKey();
        }
    }
}
