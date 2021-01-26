using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace BankTellerExercise.Tests
{
    [TestClass]
    public class BankCustomerTests
    {
        private Type custType;
        private Type ccType;
        private PropertyInfo[] properties;

        [TestInitialize]
        public void SetUpBankAccount()
        {
            custType = Type.GetType("BankTellerExercise.BankCustomer, BankTellerExercise");
            ccType = Type.GetType("BankTellerExercise.CreditCardAccount, BankTellerExercise");
            properties = custType.GetProperties();
        }

        [TestMethod]
        public void ConstructorAndSettersTest()
        {
            object customer = Activator.CreateInstance(custType, new object[] { });

            SetPropertyValue(customer, "Name", "TTEST");
            SetPropertyValue(customer, "Address", "TEST");
            SetPropertyValue(customer, "PhoneNumber", "3329383394");

            object name = GetPropertyValue(customer, "Name");
            object address = GetPropertyValue(customer, "Address");
            object phoneNumber = GetPropertyValue(customer, "PhoneNumber");

            Assert.AreEqual(name, "TTEST");
            Assert.AreEqual(address, "TEST");
            Assert.AreEqual(phoneNumber, "3329383394");
        }

        [TestMethod]
        public void AddAccountTest()
        {
            object customer = Activator.CreateInstance(custType, new object[] { });
            CheckingAccount chk = new CheckingAccount("Bernie", "33232443");
            SavingsAccount sav = new SavingsAccount("Bernie", "282939283");
            object cc = Activator.CreateInstance(ccType, new object[] { "Bernie", "6011234398473348" });

            MethodInfo addAcctMethod = custType.GetMethod("AddAccount");

            addAcctMethod.Invoke(customer, new object[] { chk });
            addAcctMethod.Invoke(customer, new object[] { sav });
            addAcctMethod.Invoke(customer, new object[] { cc });

            MethodInfo getAcct = custType.GetMethod("GetAccounts");

            object accounts = getAcct.Invoke(customer, new object[] { });

            Assert.IsTrue(((object[])accounts).Length == 3);
            Assert.AreEqual(chk, ((object[])accounts)[0]);
            Assert.AreEqual(sav, ((object[])accounts)[1]);
            Assert.AreEqual(cc, ((object[])accounts)[2]);
        }

        [TestMethod]
        public void IsVipInOneAccountTest()
        {
            object customer = Activator.CreateInstance(custType, new object[] { });
            CheckingAccount chk = new CheckingAccount("Bernie", "33232443");
            SavingsAccount sav = new SavingsAccount("Bernie", "282939283");
            object cc = Activator.CreateInstance(ccType, new object[] { "Bernie", "6011234398473348" });

            MethodInfo addAcctMethod = custType.GetMethod("AddAccount");

            addAcctMethod.Invoke(customer, new object[] { chk });
            addAcctMethod.Invoke(customer, new object[] { sav });
            addAcctMethod.Invoke(customer, new object[] { cc });

            chk.Deposit(25000);

            object isVipValue = GetPropertyValue(customer, "IsVip");

            Assert.IsTrue((bool)isVipValue);
        }

        [TestMethod]
        public void IsVipInMultipleAccountsTest()
        {
            object customer = Activator.CreateInstance(custType, new object[] { });
            CheckingAccount chk = new CheckingAccount("Bernie", "33232443");
            SavingsAccount sav = new SavingsAccount("Bernie", "282939283");
            object cc = Activator.CreateInstance(ccType, new object[] { "Bernie", "6011234398473348" });

            MethodInfo addAcctMethod = custType.GetMethod("AddAccount");

            addAcctMethod.Invoke(customer, new object[] { chk });
            addAcctMethod.Invoke(customer, new object[] { sav });
            addAcctMethod.Invoke(customer, new object[] { cc });

            chk.Deposit(10000);
            sav.Deposit(15000);

            object isVipValue = GetPropertyValue(customer, "IsVip");

            Assert.IsTrue((bool)isVipValue);
        }

        [TestMethod]
        public void IsVipWithCreditDebtTest()
        {
            object customer = Activator.CreateInstance(custType, new object[] { });
            CheckingAccount chk = new CheckingAccount("Bernie", "33232443");
            SavingsAccount sav = new SavingsAccount("Bernie", "282939283");
            object cc = Activator.CreateInstance(ccType, new object[] { "Bernie", "6011234398473348" });

            MethodInfo addAcctMethod = custType.GetMethod("AddAccount");

            addAcctMethod.Invoke(customer, new object[] { chk });
            addAcctMethod.Invoke(customer, new object[] { sav });
            addAcctMethod.Invoke(customer, new object[] { cc });

            chk.Deposit(15000);
            sav.Deposit(15000);

            MethodInfo chargeMethod = ccType.GetMethod("Charge");
            chargeMethod.Invoke(cc, new object[] { 5000 });

            object isVipValue = GetPropertyValue(customer, "IsVip");

            Assert.IsTrue((bool)isVipValue);
        }

        [TestMethod]
        public void IsNOTVipTest()
        {
            object customer = Activator.CreateInstance(custType, new object[] { });
            CheckingAccount chk = new CheckingAccount("Bernie", "33232443");
            SavingsAccount sav = new SavingsAccount("Bernie", "282939283");
            object cc = Activator.CreateInstance(ccType, new object[] { "Bernie", "6011234398473348" });

            MethodInfo addAcctMethod = custType.GetMethod("AddAccount");

            addAcctMethod.Invoke(customer, new object[] { chk });
            addAcctMethod.Invoke(customer, new object[] { sav });
            addAcctMethod.Invoke(customer, new object[] { cc });

            object isVipValue = GetPropertyValue(customer, "IsVip");

            Assert.IsFalse((bool)isVipValue);
        }

        [TestMethod]
        public void IsNOTVipAt24999Test()
        {
            object customer = Activator.CreateInstance(custType, new object[] { });
            CheckingAccount chk = new CheckingAccount("Bernie", "33232443");
            SavingsAccount sav = new SavingsAccount("Bernie", "282939283");
            object cc = Activator.CreateInstance(ccType, new object[] { "Bernie", "6011234398473348" });

            MethodInfo addAcctMethod = custType.GetMethod("AddAccount");

            addAcctMethod.Invoke(customer, new object[] { chk });
            addAcctMethod.Invoke(customer, new object[] { sav });
            addAcctMethod.Invoke(customer, new object[] { cc });

            chk.Deposit(24999);

            object isVipValue = GetPropertyValue(customer, "IsVip");

            Assert.IsFalse((bool)isVipValue);
        }

        [TestMethod]
        public void IsNOTVipWithCreditDebtTest()
        {
            object customer = Activator.CreateInstance(custType, new object[] { });
            CheckingAccount chk = new CheckingAccount("Bernie", "33232443");
            SavingsAccount sav = new SavingsAccount("Bernie", "282939283");
            object cc = Activator.CreateInstance(ccType, new object[] { "Bernie", "6011234398473348" });

            MethodInfo addAcctMethod = custType.GetMethod("AddAccount");

            addAcctMethod.Invoke(customer, new object[] { chk });
            addAcctMethod.Invoke(customer, new object[] { sav });
            addAcctMethod.Invoke(customer, new object[] { cc });

            chk.Deposit(15000);
            sav.Deposit(15000);

            MethodInfo chargeMethod = ccType.GetMethod("Charge");
            chargeMethod.Invoke(cc, new object[] { 5001 });

            object isVipValue = GetPropertyValue(customer, "IsVip");

            Assert.IsFalse((bool)isVipValue);
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

        private void SetPropertyValue(object instance, string propName, object propValue)
        {
            foreach (PropertyInfo prop in properties)
            {
                if (prop.Name == propName && prop.CanWrite)
                {
                    prop.SetValue(instance, propValue);
                }
            }
        }
    }
}
