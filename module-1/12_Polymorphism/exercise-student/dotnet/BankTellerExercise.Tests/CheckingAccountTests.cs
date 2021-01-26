using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace BankTellerExercise.Tests
{
    [TestClass]
    public class CheckingAccountTests
    {
        private Type type;
        private PropertyInfo[] properties;

        [TestInitialize]
        public void SetUpBankAccount()
        {
            type = Type.GetType("BankTellerExercise.CheckingAccount, BankTellerExercise");
            properties = type.GetProperties();
        }

        [TestMethod]
        public void WithdrawNegativeWithFeeBalanceTest()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", -1);

            int newBalance = chkAccount.Withdraw(1);

            Assert.AreEqual(newBalance, -12);
            Assert.AreEqual(chkAccount.Balance, -12);
        }

        [TestMethod]
        public void WithdrawPositiveWithFeeTest()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", -1);

            int newBalance = chkAccount.Withdraw(2);

            Assert.AreEqual(newBalance, -13);
            Assert.AreEqual(chkAccount.Balance, -13);
        }

        [TestMethod]
        public void WithdrawNegativeBalanceBelow100Test()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", -100);

            int newBalance = chkAccount.Withdraw(2);

            Assert.AreEqual(newBalance, -100);
            Assert.AreEqual(chkAccount.Balance, -100);
        }

        [TestMethod]
        public void WithdrawPositiveBalanceTest()
        {
            CheckingAccount chkAccount = new CheckingAccount("", "", 10);

            int newBalance = chkAccount.Withdraw(5);

            Assert.AreEqual(newBalance, 5);
            Assert.AreEqual(chkAccount.Balance, 5);
        }

        [TestMethod]
        public void TransferTest()
        {
            CheckingAccount source = new CheckingAccount("", "", 50);
            CheckingAccount destination = new CheckingAccount("", "");

            MethodInfo method = type.GetMethod("TransferTo");

            object[] methodParameters = new object[] { destination, 24 };

            method.Invoke(source, methodParameters);

            object newSourceBalance = GetPropertyValue(source, "Balance");

            Assert.AreEqual(newSourceBalance, 26);
            Assert.AreEqual(destination.Balance, 24);
            Assert.AreEqual(source.Balance, 26);
        }

        private object GetPropertyValue(object instance, string propName)
        {
            object retVal = new object();
            foreach (PropertyInfo prop in properties)
            {
                if (prop.Name == propName)
                {
                    retVal = prop.GetValue(instance);
                }
            }
            return retVal;
        }
    }
}
