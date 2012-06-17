using System;
using System.Net;

using Gate.Hosts.Kayak;
using Kayak;

namespace KayakTest
{

    class Program
    {
        static void Main(string[] args)
        {
            var ep = new IPEndPoint(IPAddress.Any, 8889);
            Console.WriteLine("Listening on " + ep);
            Console.WriteLine("Press CTRL+C to quit :-)");
            KayakGate.Start(new SchedulerDelegate(), ep, Gate.Adapters.Nancy.NancyAdapter.App());
        }
    }
}
