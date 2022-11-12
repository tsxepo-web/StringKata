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
            Calculator calculator = new();
            var result = Calculator.Add("");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void ShouldReturnTheNumberThatIsPasssed()
        {
            Calculator calculator = new();
            var result = Calculator.Add("1");
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void ShouldReturnTheSumOfTwoStringNumberPasssed()
        {
            Calculator calculator = new();
            var result = Calculator.Add("1,2");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldReturnTheSumOfInfiniteStringNumberPasssed()
        {
            Calculator calculator = new();
            var result = Calculator.Add("1,2,3,4,5");
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void AddNewLineBetweenStringNumbersAsSeparators()
        {
            Calculator calculator = new();
            var result = Calculator.Add("1,2\n");
            Assert.That(result, Is.EqualTo(3));
        }
    }
}