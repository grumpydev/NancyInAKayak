namespace KayakTest
{
    using KayakTest.Models;

    using Nancy;

    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = _ => View["test", new UserModel { FirstName = "Jesse", LastName = "Mach" }];
        }
    }
}