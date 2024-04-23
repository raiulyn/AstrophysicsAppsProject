using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

// RAYMOND LAI
// STUDENT ID: 30082866
// DATE: 23/04/2024

namespace AstroServer
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        double StarVelocty(double observed, double rest);
        [OperationContract]
        double StarDistance(double archseconds);
        [OperationContract]
        double TemperatureInKelvin(double celsius);
        [OperationContract]
        double EventHorizon(double mass);
    }
}