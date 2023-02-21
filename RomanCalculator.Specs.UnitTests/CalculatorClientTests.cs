using NUnit.Framework;

namespace RomanCalculator.Specs.UnitTests
{
    [TestFixture]
    public class CalculatorClientTests
    {

        [TestCase("(MMMDCCXXIV - MMCCXXIX) * II", "MMCMXC")]
        [TestCase("(MMMDCCXXIV - MMCCXXIX * III) * II", "-MMMMMCMXXXIV")]
        public void When_expression_is_valid_should_return_result(string expression, string expectedResult)
        {
            // Arrange
            var client = new CalculatorClient();

            // Act
            var result = client.Evaluate(expression);

            // Assert
            Assert.AreEqual(expectedResult, result);

        }

    }
}
