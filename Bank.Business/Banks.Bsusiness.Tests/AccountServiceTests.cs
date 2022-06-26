using Bank.Business.Entities;
using Bank.Business.Entities.Accounts;
using Moq;

namespace Bank.Business.Tests {
    [TestFixture]
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        [TestCaseSource(nameof(WithdrawalTestCases))]
        public void IndividualWithdrawalTest(decimal balance, decimal withdrawalAmount, bool expectedSuccess) {
            // Arrange
            var bank = new BankBase { Name = "Test Bank" };
            var owner = new Owner { Name = "Test Owner" };
            var account = new IndividualAccount(bank, owner, balance);

            var mockTransactionRepo = new Mock<Business.Abstract.ITransactionRepository>();
            mockTransactionRepo.Setup(s => s.Add(It.IsAny<Transaction>())).Returns(new Models.TransactionResponse());

            var target = new Services.AccountService(mockTransactionRepo.Object);

            // Act
            var result = target.Withdraw(account, withdrawalAmount);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(expectedSuccess, Is.EqualTo(result.Success));
            mockTransactionRepo.Verify(m => m.Add(It.Is<Transaction>(t => t.Amount == withdrawalAmount && t.TransactionType == Enumerations.TransactionType.Withdrawal)), expectedSuccess ? Times.Once : Times.Never);
        }

        static object[] WithdrawalTestCases = {
            new TestCaseData(new object[] { 600M, 501M, false }).SetName("withdrawal over limit, causes error."),
            new TestCaseData(new object[] { 600M, 500M, true }).SetName("withdrawal at limit, success."),
            new TestCaseData(new object[] { 499M, 500M, false }).SetName("withdrawal over balance, causes error."),
        };

    }
}