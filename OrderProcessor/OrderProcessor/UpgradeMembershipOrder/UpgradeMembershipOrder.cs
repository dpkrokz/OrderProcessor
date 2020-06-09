using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor.UpgradeMembershipOrder
{
    class UpgradeMembershipOrder : AbstractOrder, IUpgradeMembershipOrder
    {
        public override bool Checkout(Product prod)
        {
            bool status = false;
            UpgradePlan();
            SendEmail();
            return status;
        }

        public bool UpgradePlan()
        {
            // Upgrade membership plan
            Console.WriteLine("Membership Upgrade Order");
            Console.WriteLine("Membership plan upgraded");
            return true;
        }

        public bool SendEmail()
        {
            // Send email to owner
            Console.WriteLine("Email sent\n");
            return true;
        }
    }
}

