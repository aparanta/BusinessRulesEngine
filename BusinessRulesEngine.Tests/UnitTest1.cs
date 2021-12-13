using NUnit.Framework;
using Moq;
using PaymentProcessor;
using PaymentProcessor.Rules;

namespace BusinessRulesEngine.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var expected = new Result { IsSuccess = true, ActionInfo = PaymentInfoEnum.PhysicalProductPayment };
            var physicalProd = new Mock<PhysicalProductPayment>();
            var manager = new Mock<RulesManager>();
           // physicalProd.SetupProperty(f => f.results);
            manager.Object.Manage(physicalProd.Object);
            var results = physicalProd.Object.results;
            Assert.That(results, Has.Exactly(1).Matches<Result>(p => p.IsSuccess == true && p.ActionInfo ==PaymentInfoEnum.PhysicalProductPayment));
           // Assert.Contains()
        }
    }
}