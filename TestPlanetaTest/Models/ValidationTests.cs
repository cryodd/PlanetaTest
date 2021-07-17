using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetaTest.Models.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        [DataRow("192.168.0.1/32")]
        public void Validation_Ip_IsIp(string IpString)
        {
            var res = Validation.IpStringValidadtion(IpString);

            Assert.IsTrue(res);
        }
        [TestMethod()]
        [DataRow("199.2222.3333.0/2")]
        public void Validation_WrongIp_IsNotIp(string IpString)
        {
            var res = Validation.IpStringValidadtion(IpString);

            Assert.IsNotNull(res);
        }
    }
}