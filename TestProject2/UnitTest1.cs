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
            double ojid = 25;

            double act = Logic.GetSquareArea(a);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void GetCircleAreaTestOrdinaryNumber()
        {
            double r = 10;
            double ojid = 314;
            double act = Logic.GetCircleArea(r);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void GetSquareAreaTestZeroNumber()
        {
            double a = 0;
            double ojid = 0;

            double act = Logic.GetSquareArea(a);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void GetSquareAreaTestNegativeNumber()
        {
            double a = -5;
            double ojid = 25;

            double act = Logic.GetSquareArea(a);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void GetCircleAreaTestZeroNumber()
        {

            double r = 0;
            double ojid = 0;
            double act = Logic.GetCircleArea(r);

            Assert.That(act, Is.EqualTo(ojid));

        }

        [Test]
        public void GetCircleAreaTestNegativeNumber()
        {

            double r = -5;
            double ojid = 78.5;
            double act = Logic.GetCircleArea(r);

            Assert.That(act, Is.EqualTo(ojid));

        }
    }
}