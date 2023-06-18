using TDD;

namespace TestTDD
{
    public class MoneyTest1
    {
        [Fact]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            var product = five.Times(2);
            Assert.Equal(10, product.amount);

            product = five.Times(3);
            Assert.Equal(15, product.amount);
        }
    }
}