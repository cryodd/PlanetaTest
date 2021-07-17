using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlanetaTest.Models.Tests
{
    [TestClass()]
    public class SubnetsManagerTests
    {
        [TestMethod()]
        [DataRow("192.168.0.1/30")]
        public void GetIP_IpString_ReturnIpPlusMask(string IpString)
        {
            var res = SubnetsManager.GetIP(IpString);

            Assert.AreEqual(("192.168.0.1", 30), res);
        }
        [TestMethod()]
        [DataRow("192.168.0.1/33")]
        public void GetIP_WrongIpString_ReturnIpPlusMask(string IpString)
        {
            var res = SubnetsManager.GetIP(IpString);

            Assert.AreNotEqual(("192.168.0.1", 33), res);
        }
    }
}