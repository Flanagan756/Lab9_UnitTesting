using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab9_Unit_Testing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDeposit()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 200m;
            //Act
            acc1.Deposit(200m);
            //Assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestWithdral()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 0m;
            //Act
            acc1.Deposit(1000m);
            acc1.WithDraw(1000m);
            //Assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestNewAccount()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 0m;
            //Act
 
            //Assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestSufficentWithdraw()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 500m;
            //Act
            acc1.Deposit(1000m);
            acc1.WithDraw(500m);
            //Assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestInsufficientWithdraw()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            acc1.Balance = 1000m;
            acc1.OverdraftLimit = 0m;
            decimal expectedBalance = 1000m;
            //Act
   
            acc1.WithDraw(5000m);
            //Assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestInsufficientWithdrawWithOverdraft()
        {
            //Arrange
            BankAccount acc1 = new BankAccount();
            acc1.OverdraftLimit = 200m;
            acc1.Balance = 500m;
            decimal expectedBalance = -100m;
            //Act
            acc1.WithDraw(600m);
            //Assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
    }
    
}
