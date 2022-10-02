using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace SolveProblems.Tests
{
    public class FibonacciTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Fibonacci_PassingANegativeNumber_ThrowException()
        {
            try
            {
                var result = Program.Fibonacci(-1);
            }
            catch (Exception e)
            {
                Assert.That(e.GetType().ToString(), Is.EqualTo("System.ArgumentException"));

                Assert.That(e.Message, Is.EqualTo("Argument exception message"));
            }

        }

        [Test]
        public void Fibonacci_PassingNumberZero_Returns0()
        {
            var result = Program.Fibonacci(0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Fibonacci_PassingNumberOne_ReturnsOne()
        {
            var result = Program.Fibonacci(1);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Fibonacci_PassingNumber10_Returns55()
        {
            var result = Program.Fibonacci(10);
            Assert.That(result, Is.EqualTo(55));
        }
    }
}