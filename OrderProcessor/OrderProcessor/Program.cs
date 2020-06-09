using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product> {
                new Product { Name="Twilight", Type=Enum.ProductType.BookOrder},
                new Product { Name="Harry Potter Movie", Type=Enum.ProductType.VideoOrder},
                new Product { Name="TV", Type=Enum.ProductType.PhysicalProductOrder},
                new Product { Name="Kindle-Harry Potter", Type=Enum.ProductType.ActivateMembershipOrder},
                new Product { Name="Kindle-Shiva Trilogy", Type=Enum.ProductType.UpgradeMembershipOrder}
                };

            foreach (var product in products)
            {
                string fullyQualifiedName = typeof(Program).ToString().Split('.')[0] +"."+ product.Type.ToString() + "." + product.Type.ToString();
                object obj = Activator.CreateInstance(Type.GetType(fullyQualifiedName));
                ((AbstractOrder)obj).Checkout(product);
            }
            Console.ReadLine();
        }
    }
}
