using NUnit.Framework;

namespace Bank
{
    [TestFixture]
    public class BankTest
    {
        [Test]
        public void TestName()
        {
            BankAccount account = new BankAccount("Alice", 500, "personal");
            Assert.AreEqual("Alice", account.Name);
        }

        [Test]
        public void TestAmount()
        {
            BankAccount account = new BankAccount("Alice", 500, "personal");
            Assert.AreEqual(500, account.Amount);
        }

        [Test]
        public void TestType()
        {
            BankAccount account = new BankAccount("Alice", 500, "personal");
            Assert.AreEqual("personal", account.Type);
        }

        [Test]
        public void TestSetName()
        {
            BankAccount account = new BankAccount("Alice", 500, "personal");
            account.Name = "Matt";
            Assert.AreEqual("Matt", account.Name);
        }

        [Test]
        public void TestSetAmount()
        {
            BankAccount account = new BankAccount("Alice", 500, "personal");
            account.Amount = 400;
            Assert.AreEqual(400, account.Amount);
        }

        [Test]
        public void TestSetType()
        {
            BankAccount account = new BankAccount("Alice", 500, "personal");
            account.Type = "business";
            Assert.AreEqual("business", account.Type);
        }

        [Test]
        public void TestDeposit()
        {
            BankAccount account = new BankAccount("Alice", 500, "personal");
            account.Deposit(50);
            Assert.AreEqual(550, account.Amount);
        }

        [Test]
        public void TestPayFeeBusiness()
        {
            BankAccount account = new BankAccount("Alice", 500, "business");
            account.PayFee();
            Assert.AreEqual(450, account.Amount);
        }

        [Test]
        public void TestPayFeePersonal()
        {
            BankAccount account = new BankAccount("Alice", 500, "personal");
            account.PayFee();
            Assert.AreEqual(490, account.Amount);
        }
    }
}