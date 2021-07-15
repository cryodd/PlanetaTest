using System;

namespace PlanetaTest
{
    public class Weather
    {
        public DateTime Date1 { get; set; }

        public int Temperatur1eC { get; set; }

        public int Temperatu1reF => 32 + (int)(Temperatur1eC / 0.5556);

        public string Summa1ry { get; set; }
    }
}
