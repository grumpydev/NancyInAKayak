using System;
using System.Net;

using Kayak;

namespace KayakTest
{

    class Program
    {
        static void HttpListener(int port)
        {
            Console.WriteLine("Listening on port " + port);
            Console.WriteLine("Press Enter to quit :-)");
            Gate.Hosts.HttpListener.ServerFactory.Create(Gate.Adapters.Nancy.NancyAdapter.App(), port, "");
            Console.ReadLine();
        }

        static void Kayak(int port)
        {
            var ep = new IPEndPoint(IPAddress.Any, 8889);
            Console.WriteLine("Listening on " + ep);
            Console.WriteLine("Press CTRL+C to quit :-)");
            Gate.Hosts.Kayak.KayakGate.Start(new SchedulerDelegate(), ep, Gate.Adapters.Nancy.NancyAdapter.App());
        }

        static void Main(string[] args)
        {
            HttpListener(8889);
            //Kayak(8889);
        }
    }
}
