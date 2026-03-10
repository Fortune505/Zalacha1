using NUnit.Framework;


namespace TestProject2
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void GetSquareAreaTestOrdinaryNumber()
        {
            double a = 5;
            double expectedResult = 25;

            double squareArea = Logic.GetSquareArea(a);

            Assert.That(squareArea, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetCircleAreaTestOrdinaryNumber()
        {
            double r = 10;
            double expectedResult = 314;
            double circleArea = Logic.GetCircleArea(r);

            Assert.That(circleArea, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetSquareAreaTestZeroNumber()
        {
            double a = 0;
            double expectedResult = 0;

            double squareArea = Logic.GetSquareArea(a);

            Assert.That(squareArea, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetSquareAreaTestNegativeNumber()
        {
            double a = -5;
            double expectedResult = 25;

            double squareArea = Logic.GetSquareArea(a);

            Assert.That(squareArea, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetCircleAreaTestZeroNumber()
        {

            double r = 0;
            double expectedResult = 0;
            double circleArea = Logic.GetCircleArea(r);

            Assert.That(circleArea, Is.EqualTo(expectedResult));

        }

        [Test]
        public void GetCircleAreaTestNegativeNumber()
        {

            double r = -5;
            double expectedResult = 78.5;
            double circleArea = Logic.GetCircleArea(r);

            Assert.That(circleArea, Is.EqualTo(expectedResult));

        }
    }
}