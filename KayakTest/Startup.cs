namespace KayakTest
{
    using Gate;
    using Gate.Kayak;

    public static class Startup
    {
        // called automatically when Kayak starts up.
        public static void Configuration(IAppBuilder builder)
        {
            // we'll create a very simple pipeline:

            builder
                // insert a middleware between Kayak and Nancy
                // to ensure Kayak objects are only accessed 
                // on Kayak's worker thread.
                .RescheduleCallbacks()

                // cap off the pipeline with Nancy
                .RunNancy();
        }
    }
}