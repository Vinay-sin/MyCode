using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Rule.Engine
{
    public class PhysicalProduct : PackingSlipShiping, CommisionPayment
    {
        public string GenerateCommision()
        {
            Console.WriteLine("Commission Generated.");

            return "True";
        }

        public  string generatePackingSlip()
        {
            Console.WriteLine("Packing List Generated.");
            return "True";
        }       
    }

    public class Book : PackingSlipDuplicate, CommisionPayment
    {
        public string createDuplicateSlip()
        {
            Console.WriteLine("Duplicate slip generated.");
            return "True";
        }

        public string GenerateCommision()
        {
            Console.WriteLine("Commission Generated.");
            return "True";
        }
    }

    public class Membership : MemberShipActivate, SendEmail
    {
        public string ActivateMembership()
        {
            Console.WriteLine("Membership Activated.");
            return "True";
        }

        public string sendEmail()
        {
            Console.WriteLine("Email Sent for Activation.");
            return "True";
        }
    }

    public class Upgrade : UpGradMemberShip, SendEmail
    {
        public string sendEmail()
        {
            Console.WriteLine("Email Sent for upgrade.");
            return "True";
        }

        public string upGradMembership()
        {
            Console.WriteLine("Membership Upgraded");
            return "True";
        }
    }

    public class Video : AddFirstAdVedio
    {
        public string addVedio()
        {
            Console.WriteLine("Vedio Added");
            return "True";
        }
    }

}
