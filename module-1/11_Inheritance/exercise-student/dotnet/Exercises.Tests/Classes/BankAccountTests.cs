using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankAccountTests
    {
        private Type type;
        private PropertyInfo[] properties;

        [TestInitialize]
        public void SetUpBankAccount()
        {
            type = Type.GetType(typeof(BankAccount).AssemblyQualifiedName);
            properties = type.GetProperties();
        }

        [TestMethod]
        public void NewCustomerHasZeroBalance()
        {
            object bankAccount = Activator.CreateInstance(type, new object[] { "", "" });

            object balanceAmt = GetPropertyValue(bankAccount, "Balance");

            Assert.AreEqual(0M, balanceAmt);
        }

        [TestMethod]
        public void NewCustomerHasStartingBalance()
        {
            object bankAccount = Activator.CreateInstance(type, new object[] { "", "", 100M });

            object balanceAmt = GetPropertyValue(bankAccount, "Balance");

            Assert.AreEqual(100M, balanceAmt);
        }

        [TestMethod]
        public void DepositIncreasesBalance()
        {
            object bankAccount = Activator.CreateInstance(type, new object[] { "", "" });

            MethodInfo method = type.GetMethod("Deposit");

            object[] methodParameters = new object[] { 100M };

            object depositReturnValue = method.Invoke(bankAccount, methodParameters);

            object balanceAmt = GetPropertyValue(bankAccount, "Balance");

            Assert.AreEqual(100M, depositReturnValue);
            Assert.AreEqual(100M, balanceAmt);
        }

        [TestMethod]
        public void WithdrawDecreasesBalance()
        {
            object bankAccount = Activator.CreateInstance(type, new object[] { "", "" });

            MethodInfo method = type.GetMethod("Withdraw");

            object[] methodParameters = new object[] { 100M };

            object withdrawReturnValue = method.Invoke(bankAccount, methodParameters);

            object balanceAmt = GetPropertyValue(bankAccount, "Balance");

            Assert.AreEqual(-100M, withdrawReturnValue);
            Assert.AreEqual(-100M, balanceAmt);
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
