using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Linq;

namespace BankTellerExercise.Tests
{
    [TestClass]
    public class IAccountableTests
    {
        private Type acctblType;
        private PropertyInfo[] properties;

        [TestInitialize]
        public void SetUpBankAccount()
        {
            acctblType = Type.GetType("BankTellerExercise.IAccountable, BankTellerExercise");
            properties = acctblType.GetProperties();
        }

        [TestMethod]
        public void IsBankAccountAccountableTest()
        {
            BankAccount sut = new BankAccount("", "");

            Assert.IsTrue(((TypeInfo)sut.GetType()).ImplementedInterfaces.Contains(acctblType));
        }

        [TestMethod]
        public void IAccountableHasBalanceProperty()
        {
            Assert.IsTrue(properties.Any(p => p.Name == "Balance"));
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
