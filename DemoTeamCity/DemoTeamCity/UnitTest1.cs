using NUnit.Framework;

namespace DemoTeamCity
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(1 == 1);
        }

        [Test]
        public void TestMethod2()
        {
            Assert.IsTrue(1 == 2);
        }

        [Test]
        public void TestMethod3()
        {
            Assert.IsTrue(1 == 1);
        }

        [Test]
        public void TestMethod4()
        {
            Assert.IsTrue(1 == 1);
        }

    }
}
