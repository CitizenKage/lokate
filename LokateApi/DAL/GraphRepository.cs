using Neo4jClient;

namespace LokateApi.DAL
{
    public class GraphRepository : IGraphRepository
    {
        public GraphRepository(IGraphClient graphClient)
        {
            GraphClient = graphClient;
        }

        public IGraphClient GraphClient { get; }
    }
}
