using System;
using Xunit;
using Business.Rule.Engine;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1_PhycalProduct()
        {
            PaymentHandler payment = new PaymentHandler();

            Assert.Equal("True", payment.BusinessRuleEngine(0));
        }
        [Fact]
        public void Test1_Book()
        {
            PaymentHandler payment = new PaymentHandler();

            Assert.Equal("True", payment.BusinessRuleEngine(1));
        }
        [Fact]
        public void Test1_MemmberShip()
        {
            PaymentHandler payment = new PaymentHandler();

            Assert.Equal("True", payment.BusinessRuleEngine(2));
        }
        [Fact]
        public void Test1_Upgrade()
        {
            PaymentHandler payment = new PaymentHandler();

            Assert.Equal("True", payment.BusinessRuleEngine(3));
        }
        [Fact]
        public void Test1_Vedio()
        {
            PaymentHandler payment = new PaymentHandler();

            Assert.Equal("True", payment.BusinessRuleEngine(4));
        }
    }
}
