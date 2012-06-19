using NancyInGate.Models;
using Nancy;

namespace NancyInGate
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = _ => View["test", new UserModel { FirstName = "Jesse", LastName = "Mach" }];
        }
    }
}