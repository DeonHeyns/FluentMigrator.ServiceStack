using ServiceStack;
using ServiceStack.DataAnnotations;

#if V3
using ServiceStack.ServiceHost;
#endif

namespace FluentMigrator.ServiceStack.ServiceModel
{
    [Route("/migrations", "GET")]
#if !V3
    [Exclude(Feature.Soap)]
#endif
    public class GetMigrations
    {
        public string ConnectionString { get; set; }
    }
}