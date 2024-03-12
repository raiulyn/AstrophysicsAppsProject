using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    public class Calculus
    {
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="archseconds"></param>
        /// <returns></returns>
        public double StarDistance(double archseconds)
        {
            var angle = 1 / archseconds;
            return angle;
        }
        /// <summary>
        /// 
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
        /// 
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
