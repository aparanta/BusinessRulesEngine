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
        public void CheckForPackingSlipWhenPhysicalProd()
        {

            var physicalProd = new Mock<PhysicalProductPayment>();
            var manager = new Mock<RulesManager>();

            manager.Object.Manage(physicalProd.Object);
            var results = physicalProd.Object.results;

            Assert.That(results, Has.Exactly(1).Matches<Result>(p => p.IsSuccess == true && p.ActionInfo == ActionInfo.GeneratePackingSlip));

        }

        [Test]
        public void CheckForCommissionWhenPhysicalProd()
        {

            var physicalProd = new Mock<PhysicalProductPayment>();
            var manager = new Mock<RulesManager>();

            manager.Object.Manage(physicalProd.Object);
            var results = physicalProd.Object.results;

            Assert.That(results, Has.Exactly(1).Matches<Result>(p => p.IsSuccess == true && p.ActionInfo == ActionInfo.IssueCommission));

        }

        [Test]
        public void CheckForEmailWhenPhysicalProd()
        {

            var physicalProd = new Mock<PhysicalProductPayment>();
            var manager = new Mock<RulesManager>();

            manager.Object.Manage(physicalProd.Object);
            var results = physicalProd.Object.results;

            Assert.That(results, Has.Exactly(1).Matches<Result>(p => p.IsSuccess == true && p.ActionInfo == ActionInfo.EmailForActivation));

        }

         [Test]
         public void CheckForDuplicatePackingSlipWhenBook()
        {

            var physicalProd = new Mock<BookPayment>();
            var manager = new Mock<RulesManager>();

            manager.Object.Manage(physicalProd.Object);
            var results = physicalProd.Object.results;

            Assert.That(results, Has.Exactly(2).Matches<Result>(p => p.IsSuccess == true && p.ActionInfo == ActionInfo.GeneratePackingSlip));

        }


    }
}