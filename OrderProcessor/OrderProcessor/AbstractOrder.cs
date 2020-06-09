using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor
{
    public abstract class AbstractOrder
    {
        public bool AddToCart(Product prod)
        {
            //Common for all product types
            throw new NotImplementedException();
        }
        public abstract bool Checkout(Product prod);
    }
}
