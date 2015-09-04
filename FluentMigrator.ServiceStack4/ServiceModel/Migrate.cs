using ServiceStack;
using ServiceStack.DataAnnotations;

#if V3
using ServiceStack.ServiceHost;
#endif

namespace FluentMigrator.ServiceStack.ServiceModel
{
    [Route("/migrations", "POST, DELETE")]
    [Route("/migrations/{Version}", "POST,DELETE")]
#if !V3
    [Exclude(Feature.Soap)]
#endif
    public sealed class Migrate
    {
        public long? Version { get; set; }

        public bool PreviewOnly { get; set; }

        public int? TimeoutSeconds { get; set; }

        public string ConnectionString { get; set; }
    }
}