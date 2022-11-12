using StringKata;

namespace StringKataTest
{
    public class CalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnZero()
        {
            Calculator calculator = new Calculator();
            var result = Calculator.Add("");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void ShouldReturnTheNumberThatIsPasssed()
        {
            Calculator calculator = new Calculator();
            var result = Calculator.Add("1");
            Assert.That(result, Is.EqualTo(1));
        }
    }
}