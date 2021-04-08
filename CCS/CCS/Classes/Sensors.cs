using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCS
{
    class Sensors
    {
        private Environment _environment;
        public Sensors(Environment environment)
        {
            _environment = environment;
        }

        public int ReadTemperature()
        {
            _environment.UpdateTemperature();
            return _environment.Temperature;
        }

        public int ReadHumidity()
        {
            _environment.UpdateHumidity();
            return _environment.Humidity;
        }
    }
}
