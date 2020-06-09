using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor.BookOrder
{
    interface IBookOrder
    {
        bool CreateDuplicatePacking();
        bool GenerateCommission();
    }
}
