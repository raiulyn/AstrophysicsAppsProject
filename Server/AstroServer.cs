using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

namespace AstroServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContract
    {
        public Calculus calculus = new Calculus();

        public double EventHorizon(double mass)
        {
            Console.WriteLine("[Received Data] Event Horizon" + " : " + mass.ToString());
            double result = calculus.EventHorizon(mass);
            Console.WriteLine("[Sending Data] Event Horizon = " + result.ToString());
            Console.WriteLine();
            return result;
        }

        public double StarDistance(double archseconds)
        {
            Console.WriteLine("[Received Data] Star Distance" + " : " + archseconds.ToString());
            double result = calculus.StarDistance(archseconds);
            Console.WriteLine("[Sending Data] Star Distance = " + result.ToString());
            Console.WriteLine();
            return result;
        }

        public double StarVelocty(double observed, double rest)
        {
            Console.WriteLine("[Received Data] Star Velocity" + " : " + observed.ToString() + " - " + rest.ToString());
            double result = calculus.StarVelocty(observed, rest);
            Console.WriteLine("[Sending Data] Star Velocity = " + result.ToString());
            Console.WriteLine();
            return result;
        }

        public double TemperatureInKelvin(double celsius)
        {
            Console.WriteLine("[Received Data] Temp In Kelvin" + " : " + celsius.ToString());
            double result = calculus.TemperatureInKelvin(celsius);
            Console.WriteLine("[Sending Data] Temp In Kelvin = " + result.ToString());
            Console.WriteLine();
            return result;
        }
    }
}