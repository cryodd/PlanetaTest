using System.Net;

namespace PlanetaTest.Models
{
    public class Subnet
    {
        public int IdSubnet { get; set; }
        public string IpAddress { get; set; }
        public int Mask { get; set; }
        public IPAddress GetIpAddress() => IPAddress.Parse(IpAddress);

    }
}