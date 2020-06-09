using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderProcessor.Enum;

namespace OrderProcessor
{
    public class Product
    {
        public string Name { get; set; }
        public ProductType Type { get; set; }
    }
}
