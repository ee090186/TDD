using TDD;

namespace TestTDD
{
    public class MoneyTest1
    {
        [Fact]
        public void TestMultiplication()
        {
            var five = new Doller(5);
            five.Times(2);
            Assert.Equal(10, five.amount);
        }
    }
}