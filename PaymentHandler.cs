using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Rule.Engine
{
 public   class PaymentHandler
    {
        public  string BusinessRuleEngine(int Type)
        {
            if (Type==0)
            {
                PhysicalProduct obj = new PhysicalProduct();
                obj.generatePackingSlip();
              return  obj.GenerateCommision();
            }
            else if (Type==1)
            {
                Book obj = new Book();
                obj.createDuplicateSlip();
             return   obj.GenerateCommision();
            }
            else if (Type==2)
            {
                Membership obj = new Membership();
                obj.ActivateMembership();
              return  obj.sendEmail();
            }
            else if (Type==3)
            {
                Upgrade obj = new Upgrade();
                obj.upGradMembership();
              return  obj.sendEmail();

            }
            else if (Type==4)
            {

                Video obj = new Video();
              return  obj.addVedio();
            }   
            else
            {
                return "False";
            }


        }

    }
}
