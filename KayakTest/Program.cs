using System;
using System.Net;

using Kayak;

namespace NancyInGate
{

    class Program
    {
        static void HttpListener(int port)
        {
            // Using HTTPListener requires administrative privileges (add appropriate line to app.manifest) or
            // see http://stackoverflow.com/questions/443640/httplistener-start-accessdenied-error-on-vista
            Gate.Hosts.HttpListener.ServerFactory.Create(Gate.Adapters.Nancy.NancyAdapter.App(), port, "");
            Console.WriteLine("HTTP.SYS is listening on port " + port);
        }

        static void Kayak(int port)
        {
            Gate.Hosts.Kayak.ServerFactory.Create(Gate.Adapters.Nancy.NancyAdapter.App(), port, Console.Out);
            Console.WriteLine("Kayak is listening on port " + port);
        }

        static void Manos(int port)
        {
            Gate.Hosts.Manos.Server.Create(Gate.Adapters.Nancy.NancyAdapter.App(), port);
            Console.WriteLine("Manos is listening on port " + port);
        }

        static void Firefly(int port)
        {
            new Gate.Hosts.Firefly.ServerFactory().Create(Gate.Adapters.Nancy.NancyAdapter.App(), port);
            Console.WriteLine("Firefly is listening on port " + port);
        }

        static void Main(string[] args)
        {
            HttpListener(8080);
            Kayak(8081);
            Manos(8082);
            Firefly(8083);
            Console.WriteLine("Press Enter to quit :-)");
            Console.ReadLine();
        }
    }
}
