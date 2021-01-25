using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class SavingsAccountTests
    {
        private Type type;
        private PropertyInfo[] properties;

        [TestInitialize]
        public void SetUpBankAccount()
        {
            type = Type.GetType(typeof(SavingsAccount).AssemblyQualifiedName);
            properties = type.GetProperties();
        }

        [TestMethod]
        public void TryToWithdrawFromNegativeBalance()
        {
            object savAccount = Activator.CreateInstance(type, new object[] { "", "", -1M });

            MethodInfo method = type.GetMethod("Withdraw");

            object[] methodParameters = new object[] { 1M };

            object withdrawReturnValue = method.Invoke(savAccount, methodParameters);

            object balanceAmt = GetPropertyValue(savAccount, "Balance");

            Assert.AreEqual(-1M, withdrawReturnValue);
            Assert.AreEqual(-1M, balanceAmt);
        }

        [TestMethod]
        public void SendPositiveIntoNegativeTest()
        {
            object savAccount = Activator.CreateInstance(type, new object[] { "", "", 1M });

            MethodInfo method = type.GetMethod("Withdraw");

            object[] methodParameters = new object[] { 2M };

            object withdrawReturnValue = method.Invoke(savAccount, methodParameters);

            object balanceAmt = GetPropertyValue(savAccount, "Balance");

            Assert.AreEqual(1M, withdrawReturnValue);
            Assert.AreEqual(1M, balanceAmt);
        }


        [TestMethod]
        public void TryToWithdrawFromPositiveBalance()
        {
            object savAccount = Activator.CreateInstance(type, new object[] { "", "", 200M });

            MethodInfo method = type.GetMethod("Withdraw");

            object[] methodParameters = new object[] { 10M };

            object withdrawReturnValue = method.Invoke(savAccount, methodParameters);

            object balanceAmt = GetPropertyValue(savAccount, "Balance");

            Assert.AreEqual(190M, withdrawReturnValue);
            Assert.AreEqual(190M, balanceAmt);
        }

        [TestMethod]
        public void TryToWithdrawFromBalanceBelow150()
        {
            object savAccount = Activator.CreateInstance(type, new object[] { "", "", 151M });

            MethodInfo method = type.GetMethod("Withdraw");

            object[] methodParameters = new object[] { 10M };

            object withdrawReturnValue = method.Invoke(savAccount, methodParameters);

            object balanceAmt = GetPropertyValue(savAccount, "Balance");

            Assert.AreEqual(139M, withdrawReturnValue);
            Assert.AreEqual(139M, balanceAmt);
        }


        [TestMethod]
        public void CanWithdrawToZero()
        {
            object savAccount = Activator.CreateInstance(type, new object[] { "", "", 10M });

            MethodInfo method = type.GetMethod("Withdraw");

            object[] methodParameters = new object[] { 8M };

            object withdrawReturnValue = method.Invoke(savAccount, methodParameters);

            object balanceAmt = GetPropertyValue(savAccount, "Balance");

            Assert.AreEqual(0M, withdrawReturnValue);
            Assert.AreEqual(0M, balanceAmt);
        }

        [TestMethod]
        public void CantWithdrawPastZeroIncludingFees()
        {
            object savAccount = Activator.CreateInstance(type, new object[] { "", "", 10M });

            MethodInfo method = type.GetMethod("Withdraw");

            object[] methodParameters = new object[] { 10M };

            object withdrawReturnValue = method.Invoke(savAccount, methodParameters);

            object balanceAmt = GetPropertyValue(savAccount, "Balance");

            Assert.AreEqual(10M, withdrawReturnValue);
            Assert.AreEqual(10M, balanceAmt);
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
