using TDD;

namespace TestTDD
{
    public class MoneyTest1
    {
        [Fact]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
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