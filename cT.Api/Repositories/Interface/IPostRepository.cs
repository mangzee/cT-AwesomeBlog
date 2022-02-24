using System.Linq;

using cT.Api.Repositories.Entities;

namespace cT.Api.Repositories.Interface
{
    /// <summary>
    /// Interface for storage abstraction (repository) of posts
    /// </summary>
    public interface IPostRepository : ICommonRepository<Post>
    {
        new IQueryable<Post> AsQuery();
        new void Add(Post item);
        new void Remove(Post item);
    }
}