namespace KayakTest
{
    using Gate;

    using Nancy.Hosting.Owin;

    public static class Extensions
    {
        // a bit of sugar for running Nancy ;)
        public static IAppBuilder RunNancy(this IAppBuilder builder)
        {
            return builder.Run(Delegates.ToDelegate(new NancyOwinHost().ProcessRequest));
        }
    }
}