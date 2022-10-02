using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace SolveProblems.Tests
{
    public class IsPrimeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsPrime_PassingANegativeNumber_ReturnsFalse()
        {
           
            var result = Program.IsPrime(-1);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPrime_PassingNumberZero_ReturnsFalse()
        {
            var result = Program.IsPrime(0);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPrime_PassingNumberOne_ReturnsTrue()
        {
            var result = Program.IsPrime(1);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPrime_PassingNumberTwo_ReturnsTrue()
        {
            var result = Program.IsPrime(2);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPrime_PassingNumberThree_ReturnsTrue()
        {
            var result = Program.IsPrime(3);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPrime_PassingNumberFour_ReturnsFalse()
        {
            var result = Program.IsPrime(4);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPrime_PassingNumber25_ReturnsFalse()
        {
            var result = Program.IsPrime(25);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPrime_PassingNumber23_ReturnsTrue()
        {
            var result = Program.IsPrime(23);
            Assert.IsTrue(result);
        }
    }
}