using System;
using System.ServiceModel;

// RAYMOND LAI
// STUDENT ID: 30082866
// DATE: 23/04/2024

namespace AAClient
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
