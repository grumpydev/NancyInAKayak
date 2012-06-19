using System;
using System.Net;

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
            Gate.Hosts.Kayak.KayakGate.Start(new SchedulerDelegate(), ep, Gate.Adapters.Nancy.NancyAdapter.App());
        }
    }
}
