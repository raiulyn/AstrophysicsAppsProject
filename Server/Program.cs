using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AstroServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address = "net.pipe://localhost/pipeme";

            ServiceHost serviceHost = new ServiceHost(typeof(AstroServer));
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address);
            serviceHost.Open();

            Console.WriteLine("ServiceHost is running. Press <<Return>> to Exit");
            Console.ReadLine();

            serviceHost.Close();
        }
    }
}
