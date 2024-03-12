using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

namespace AstroServer
{
    internal class AstroServer : IAstroContract
    {
        public Calculus calculus = new Calculus();
        public double EventHorizon(double mass)
        {
            return calculus.EventHorizon(mass);
        }

        public double StarDistance(double archseconds)
        {
            return calculus.StarDistance(archseconds);
        }

        public double StarVelocty(double observed, double rest)
        {
            return calculus.StarVelocty(observed, rest);
        }

        public double TemperatureInKelvin(double celsius)
        {
            return calculus.TemperatureInKelvin(celsius);
        }
    }
}
