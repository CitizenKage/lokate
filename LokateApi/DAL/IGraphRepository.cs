using Neo4jClient;

namespace LokateApi.DAL
{
    public interface IGraphRepository
    {
        IGraphClient GraphClient { get; }
    }
}
