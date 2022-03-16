using System;
using Xunit;
using Unit_Testing;
namespace ATMTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1000, Program.ViewBalance());
        }
     
    
        [Fact]
        public void Withdraw1()
        {
            Program.Withdraw(100);
            Assert.Equal(900, Program.ViewBalance());
        }
        [Fact]
        public void Withdraw2()
        {
            Program.Withdraw(-10);
            Assert.Equal(1000, Program.ViewBalance());
        }
        [Fact]
        public void Deposit1()
        {
            Program.Deposit(100);
            Assert.Equal(1100, Program.ViewBalance());
        }
        [Fact]
        public void Deposit2()
        {
            Program.Deposit(200);
            Assert.Equal(1200, Program.ViewBalance());
        }

    }
    
}
