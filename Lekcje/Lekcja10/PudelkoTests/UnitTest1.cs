using Lekcja10;

namespace PudelkoTests
{
    public class PudelkoOperatorPlusTests
    {
        [Fact]
        public void CorrectSumOfTwoBoxes()
        {
            Pudelko p1 = new Pudelko(1, 1, 1);
            Pudelko p2 = new Pudelko(1, 1, 1);
            Pudelko p3 = p1 + p2;
            Assert.Equal(2, p3.A);
            Assert.Equal(2, p3.B);
            Assert.Equal(2, p3.C);
        }
    }
}