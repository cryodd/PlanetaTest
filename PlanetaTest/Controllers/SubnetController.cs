using Microsoft.AspNetCore.Mvc;
using PlanetaTest.Models;
using System;

namespace PlanetaTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubnetController : ControllerBase
    {

        [HttpPost("{IpAdress}")]
        public ActionResult<String> Post(string IpAdress)
        {
            var Ip = SubnetsManager.GetIP(IpAdress);
            if (Ip.IpAddress == "")
            {
                return BadRequest("Cannot convert IpAddress");
            }
            Exception e = SubnetsManager.InsertIntoSubnet(Ip.IpAddress, Ip.Mask);
            if (e != null)
            {
                return e.Message;
            }
            return Ok();
        }
    }
}
