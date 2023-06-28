using System.Diagnostics;
using System.Linq.Expressions;
using TDD;

namespace TestTDD
{
    public class MoneyTest1
    {
        [Fact]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);

            Assert.Equal(Money.Dollar(10), five.Times(2));
            Assert.Equal(Money.Dollar(15), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.Dollar(5).Equals(
                        Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(
                         Money.Dollar(6)));
            Assert.False(Money.Franc(5).Equals(
                         Money.Dollar(5)));
        }

        [Fact]
        public void TestCurrency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency);
            Assert.Equal("CHF", Money.Franc(1).Currency);
        }

        [Fact]
        public void TestSimpleAddition()
        {
            var five = Money.Dollar(5);
            IExpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");

            Assert.Equal(Money.Dollar(10), reduced);
        }

        [Fact]
        public void TestPlusReturnsSum()
        {
            var five = Money.Dollar(5);
            IExpression result = five.Plus(five);
            var sum = (Sum)result;
            Assert.Equal(five, sum.Augend);
            Assert.Equal(five, sum.Addend);
        }

        [Fact]
        public void TestReduceSum()
        {
            var sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            var bank = new Bank();
            var result = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(7), result);
        }

    }
}