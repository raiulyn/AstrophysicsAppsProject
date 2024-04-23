using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// RAYMOND LAI
// STUDENT ID: 30082866
// DATE: 23/04/2024

namespace AstroMath
{
    public class Calculus
    {
        /// <summary>
        /// Takes in two parameters (observed and rest) and calculates them into velocity
        /// </summary>
        /// <param name="observed"></param>
        /// <param name="rest"></param>
        /// <returns></returns>
        public double StarVelocty(double observed, double rest)
        {
            var change = observed - rest;
            var speed = 299792458;
            return speed * (change / rest);
        }
        /// <summary>
        /// Takes in the arch seconds and calculates it into the distance to a star
        /// </summary>
        /// <param name="archseconds"></param>
        /// <returns></returns>
        public double StarDistance(double archseconds)
        {
            var angle = 1 / archseconds;
            return angle;
        }
        /// <summary>
        /// Takes in a celsius and converts it into Kelvin temperature
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public double TemperatureInKelvin(double celsius)
        {
            if (celsius < -273) { celsius = -273; }
            var result = celsius + 273;
            if (result < 0) { result = 0; }
            return result;
        }
        /// <summary>
        /// Takes in mass and calculates it into the size of Event Horizon
        /// </summary>
        /// <param name="mass"></param>
        /// <returns></returns>
        public double EventHorizon(double mass)
        {
             double g = 6.674 * Math.Pow(10, -11);
            return (2 * g * mass) / Math.Pow(299792458, 2);
        }
    }
}
