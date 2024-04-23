using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

// RAYMOND LAI
// STUDENT ID: 30082866
// DATE: 23/04/2024

namespace AstroServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContract
    {
        public Calculus calculus = new Calculus();

        public double EventHorizon(double mass)
        {
            double result = calculus.EventHorizon(mass);
            return result;
        }

        public double StarDistance(double archseconds)
        {
            double result = calculus.StarDistance(archseconds);
            return result;
        }

        public double StarVelocty(double observed, double rest)
        {
            double result = calculus.StarVelocty(observed, rest);
            return result;
        }

        public double TemperatureInKelvin(double celsius)
        {
            double result = calculus.TemperatureInKelvin(celsius);
            return result;
        }
    }
}