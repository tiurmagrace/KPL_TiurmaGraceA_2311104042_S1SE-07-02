using Microsoft.VisualStudio.TestTools.UnitTesting;
using tjmod12_2311104042;

namespace tjmod12_2311104042Test
{
    [TestClass]
    public class PangkatHelperTest
    {
        [TestMethod]
        public void TestNormal()
        {
            Assert.AreEqual(8, PangkatHelper.CariNilaiPangkat(2, 3));
        }

        [TestMethod]
        public void TestB0()
        {
            Assert.AreEqual(1, PangkatHelper.CariNilaiPangkat(5, 0));
            Assert.AreEqual(1, PangkatHelper.CariNilaiPangkat(0, 0)); 
        }

        [TestMethod]
        public void TestBNegatif()
        {
            Assert.AreEqual(-1, PangkatHelper.CariNilaiPangkat(5, -2));
        }

        [TestMethod]
        public void TestBOverLimit()
        {
            Assert.AreEqual(-2, PangkatHelper.CariNilaiPangkat(2, 11));
        }

        [TestMethod]
        public void TestAOverLimit()
        {
            Assert.AreEqual(-2, PangkatHelper.CariNilaiPangkat(101, 5));
        }

        [TestMethod]
        public void TestOverflow()
        {
            Assert.AreEqual(-3, PangkatHelper.CariNilaiPangkat(100, 10));
        }

        [TestMethod]
        public void TestEdgeValidInput()
        {
            Assert.AreEqual(10000, PangkatHelper.CariNilaiPangkat(100, 2));
        }
    }
}
