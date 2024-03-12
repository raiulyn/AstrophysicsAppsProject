using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

namespace AstroServer
{
    internal interface IAstroContract
    {
        public double StarVelocty(double observed, double rest);
        public double StarDistance(double archseconds);
        public double TemperatureInKelvin(double celsius);
        public double EventHorizon(double mass);
    }
}
