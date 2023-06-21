using TDD;

namespace TestTDD
{
    public class MoneyTest1
    {
        [Fact]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.Equal(new Dollar(10), five.Times(2));

            Assert.Equal(new Dollar(15), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5).Equals(
                        new Dollar(5)));
            Assert.False(new Dollar(5).Equals(
                         new Dollar(6)));
            Assert.True(new Franc(5).Equals(
                        new Franc(5)));
            Assert.False(new Franc(5).Equals(
                         new Franc(6)));
            Assert.False(new Franc(5).Equals(
                         new Dollar(5)));
        }
        [Fact]
        public void TestFrancMultiplication()
        {
            var five = new Franc(5);
            Assert.Equal(new Franc(10), five.Times(2));

            Assert.Equal(new Franc(15), five.Times(3));
        }
    }
}