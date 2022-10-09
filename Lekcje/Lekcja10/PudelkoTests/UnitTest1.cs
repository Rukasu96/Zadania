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

        [Theory]
        [InlineData(-1, 1, 1, UnitOfMeasure.meter)]
        [InlineData(1, -1, 1, UnitOfMeasure.meter)]
        [InlineData(1, 1, -1, UnitOfMeasure.meter)]
        [InlineData(10.1, 1, 1, UnitOfMeasure.meter)]
        [InlineData(1, 10.1, 1, UnitOfMeasure.meter)]
        [InlineData(1, 1, 10.1, UnitOfMeasure.meter)]
        [InlineData(-0.1, 1, 1, UnitOfMeasure.milimeter)]
        public void PudelkoIncorrectSize(double a, double b, double c, UnitOfMeasure unit)
        {
            Assert.Throws<ArgumentException>(() => new Pudelko(a, b, c, unit));
        }

        [Fact]
        public void EqualsTest()
        {
            var p1 = new Pudelko(1, 1, 1);
            var p2 = new Pudelko(1, 1, 1);
            Assert.True(p1.Equals(p2));
        }

        [Fact]
        public void EqualsNullTest()
        {
            Pudelko p1 = new Pudelko(1, 1, 1);
            Pudelko p2 = null;
            Assert.False(p1.Equals(p2));
        }
    }
}