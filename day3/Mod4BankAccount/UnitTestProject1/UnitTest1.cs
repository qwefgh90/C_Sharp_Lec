using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mod4BankAccount;

namespace UnitTestProject1
{
    [TestClass]
    public class TestWithdraw
    {
        [TestMethod]
        public void TestMethod1()
        {
            BankAccount a = new BankAccount(1, "홍길동", 10000);
            bool b = a.Withdraw(20000);
            Assert.IsFalse(b, "잔액부족 테스트 실패");
        }
    }
}
