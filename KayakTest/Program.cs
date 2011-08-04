using System;

namespace KayakTest
{
    using System.Diagnostics;
    using System.Net;

    using Gate.Kayak;

    class Program
    {
        static void Main(string[] args)
        {
            var ep = new IPEndPoint(IPAddress.Any, 8889);
            Console.WriteLine("Listening on " + ep);
            Console.WriteLine("Press CTRL+C to quit :-)");
            Process.Start("http://localhost:8889");
            KayakGate.Start(new SchedulerDelegate(), ep, Startup.Configuration);
        }
    }
}
