using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor.VideoOrder
{
    class VideoOrder : AbstractOrder, IVideoOrder
    {
        public override bool Checkout(Product prod)
        {
            bool status = false;
            CreatePackingSlip();
            return status;
        }

        public bool CreatePackingSlip()
        {
            // Create packing slip with free video
            Console.WriteLine("Video Order");
            Console.WriteLine("Packing slip created after adding free video\n");
            return true;
        }
    }
}
