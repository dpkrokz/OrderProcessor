using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor.UpgradeMembershipOrder
{
    interface IUpgradeMembershipOrder
    {
        bool UpgradePlan();
        bool SendEmail();
    }
}
