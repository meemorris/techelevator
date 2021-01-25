using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class CheckingAccountTests
    {
        private Type type;
        private PropertyInfo[] properties;

        [TestInitialize]
        public void SetUpBankAccount()
        {
            type = Type.GetType(typeof(CheckingAccount).AssemblyQualifiedName);
            properties = type.GetProperties();
        }

        [TestMethod]
        public void WithdrawNegativeWithFeeBalance_Test()
        {
            object checkAccount = Activator.CreateInstance(type, new object[] { "", "", -1M });

            MethodInfo method = type.GetMethod("Withdraw");

            object[] methodParameters = new object[] { 1M };

            object withdrawReturnValue = method.Invoke(checkAccount, methodParameters);

            object balanceAmt = GetPropertyValue(checkAccount, "Balance");

            Assert.AreEqual(-12M, withdrawReturnValue);
            Assert.AreEqual(-12M, balanceAmt);
        }

        [TestMethod]
        public void WithdrawPositiveWithFee_Test()
        {
            object checkAccount = Activator.CreateInstance(type, new object[] { "", "", -1M });

            MethodInfo method = type.GetMethod("Withdraw");

            object[] methodParameters = new object[] { 2M };

            object withdrawReturnValue = method.Invoke(checkAccount, methodParameters);

            object balanceAmt = GetPropertyValue(checkAccount, "Balance");

            Assert.AreEqual(-13M, withdrawReturnValue);
            Assert.AreEqual(-13M, balanceAmt);
        }

        [TestMethod]
        public void WithdrawNegativeBalanceBelow100_Test()
        {
            object checkAccount = Activator.CreateInstance(type, new object[] { "", "", -100M });

            MethodInfo method = type.GetMethod("Withdraw");

            object[] methodParameters = new object[] { 2M };

            object withdrawReturnValue = method.Invoke(checkAccount, methodParameters);

            object balanceAmt = GetPropertyValue(checkAccount, "Balance");

            Assert.AreEqual(-100M, withdrawReturnValue);
            Assert.AreEqual(-100M, balanceAmt);
        }

        [TestMethod]
        public void WithdrawPositiveBalance_Test()
        {
            object checkAccount = Activator.CreateInstance(type, new object[] { "", "", 10M });

            MethodInfo method = type.GetMethod("Withdraw");

            object[] methodParameters = new object[] { 5M };

            object withdrawReturnValue = method.Invoke(checkAccount, methodParameters);

            object balanceAmt = GetPropertyValue(checkAccount, "Balance");

            Assert.AreEqual(5M, withdrawReturnValue);
            Assert.AreEqual(5M, balanceAmt);
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
