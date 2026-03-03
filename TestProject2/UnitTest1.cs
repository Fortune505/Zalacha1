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
        public void TestGetSKv1()
        {
            double a = 5;
            double ojid = 25;

            double act = LogicBPLA.GetSKv(a);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetSKr2()
        {
            double r = 10;
            double ojid = 314;
            double act = LogicBPLA.GetSKr(r);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetSkvNole()
        {
            double a = 0;
            double ojid = 0;

            double act = LogicBPLA.GetSKv(a);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetSKvOtri()
        {
            double a = -5;
            double ojid = 25;

            double act = LogicBPLA.GetSKv(a);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetSKrNole()
        {

            double r = 0;
            double ojid = 0;
            double act = LogicBPLA.GetSKr(r);

            Assert.That(act, Is.EqualTo(ojid));

        }

        [Test]
        public void TestGetSKrOtri()
        {

            double r = -5;
            double ojid = 78.5;
            double act = LogicBPLA.GetSKr(r);

            Assert.That(act, Is.EqualTo(ojid));

        }
    }
}