using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor.PhysicalProductOrder
{
    class PhysicalProductOrder : AbstractOrder, IPhysicalProductOrder
    {
        public override bool Checkout(Product prod)
        {
            bool status = false;
            CreatePackingSlip();
            GenerateCommission();
            return status;
        }

        public bool CreatePackingSlip()
        {
            // Create packing slip
            Console.WriteLine("Physical Order");
            Console.WriteLine("Packing slip created");
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
