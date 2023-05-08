namespace RomanCalculator.Test
{
    [TestFixture]
    public class RomanCalculatorTest
    {
        [TestCase("I", "I", "II")]
        [TestCase("II", "II", "IV")]
        [TestCase("I", "II", "III")]
        public void AddTwoRomanStringsShouldReturnSumAsRomanString(String a, String b, String expected)
        {
            Assert.That(RomanCalculator.Add(a, b), Is.EqualTo(expected));
        }
    }
}