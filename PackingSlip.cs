using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Rule.Engine
{
    public interface PackingSlipShiping
    {
        string generatePackingSlip();
    }

    public interface PackingSlipDuplicate
    {
        string createDuplicateSlip();

    }
    public interface MemberShipActivate
    {
        string ActivateMembership();
    }

    public interface UpGradMemberShip
    {
        string upGradMembership();
    }

    public interface SendEmail
        {
        string sendEmail();
        }

    public interface AddFirstAdVedio
    {
        string addVedio();

    }
    public interface CommisionPayment
    {
      string  GenerateCommision();
    }

   
}
