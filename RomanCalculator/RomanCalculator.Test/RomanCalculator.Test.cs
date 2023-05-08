namespace RomanCalculator.Test
{
    [TestFixture]
    public class RomanCalculatorTest
    {
        [TestCase("I", "I", "II")]
        [TestCase("I", "II", "III")]
        [TestCase("II", "II", "IV")]
        [TestCase("V", "V", "X")]
        public void AddTwoRomanStringsShouldReturnSumAsRomanString(String a, String b, String expected)
        {
            Assert.That(RomanCalculator.Add(a, b), Is.EqualTo(expected));
        }
    }
}