using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor.ActivateMembershipOrder
{
    class ActivateMembershipOrder : AbstractOrder, IActivateMembershipOrder
    {
        public override bool Checkout(Product prod)
        {
            bool status = false;
            ActivatePlan();
            SendEmail();
            return status;
        }

        public bool ActivatePlan()
        {
            // Activate membership
            Console.WriteLine("Membership Activation Order");
            Console.WriteLine("Membership plan activated");
            return true;
        }

        public bool SendEmail()
        {
            // Send email
            Console.WriteLine("Email sent\n");
            return true;
        }
    }
}
