using cT.Api.Repositories.Entities;
using cT.Api.Repositories.Interface;
using System.Linq;

namespace cT.Api.Repositories
{
    /// <summary>
    /// Implementation for storage abstraction (repository) of posts bound to an in-memory repository
    /// </summary>
    public class PostRepository : InMemoryRepository<Post>, IPostRepository
    {
    }
}