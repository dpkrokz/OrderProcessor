using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor.BookOrder
{
    class BookOrder : AbstractOrder, IBookOrder
    {
        public override bool Checkout(Product prod)
        {
            bool status = false;
            CreateDuplicatePacking();
            GenerateCommission();
            return status;
        }

        public bool CreateDuplicatePacking()
        {
            // Create duplicate packing slip for the royalty department
            Console.WriteLine("Book Order");
            Console.WriteLine("Duplicate packing slip created");
            return true;
        }

        public bool GenerateCommission()
        {
            // Generate commission payment for agent
            Console.WriteLine("Commission generated for agent\n");
            return true;
        }
    }
}
