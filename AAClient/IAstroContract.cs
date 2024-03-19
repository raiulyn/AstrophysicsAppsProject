using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

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
