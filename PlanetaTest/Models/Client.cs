using System;

namespace PlanetaTest.Models
{
    public class Client
    {
        public long Identifer { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Subnet Subnet { get; set; }

    }
}