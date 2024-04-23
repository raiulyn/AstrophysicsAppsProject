using System.Diagnostics;

// RAYMOND LAI
// STUDENT ID: 30082866
// DATE: 23/04/2024

namespace TestAstroDLL
{
    [TestClass]
    public class UnitTest1
    {
        //private const var Expected = ;

        [TestMethod]
        public void TestMethodVelocity()
        {
            AstroMath.Calculus calculus = new AstroMath.Calculus();
            var velocityResult = calculus.StarVelocty(500.1, 500);

            Console.WriteLine(velocityResult);
        }
        [TestMethod]
        public void TestMethodDistance()
        {
            AstroMath.Calculus calculus = new AstroMath.Calculus();
            var distanceResult = calculus.StarDistance(0.547);

            Console.WriteLine(distanceResult);
        }
        [TestMethod]
        public void TestMethodTemperature()
        {
            AstroMath.Calculus calculus = new AstroMath.Calculus();
            var tempResult = calculus.TemperatureInKelvin(27);

            Console.WriteLine(tempResult);
        }
        [TestMethod]
        public void TestMethodEventHorizon()
        {
            AstroMath.Calculus calculus = new AstroMath.Calculus();
            var evHorizenResult = calculus.EventHorizon(8.2 * Math.Pow(10, 36));

            Console.WriteLine(evHorizenResult);
        }
    }
}