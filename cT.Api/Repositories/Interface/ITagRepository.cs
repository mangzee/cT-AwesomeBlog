using cT.Api.Repositories.Entities;
using System.Linq;

namespace cT.Api.Repositories.Interface
{
    /// <summary>
    /// Interface for storage abstraction (repository) of tags
    /// </summary>
    public interface ITagRepository : ICommonRepository<Tag>
    {
        new IQueryable<Tag> AsQuery();
        new void Add(Tag item);
        new void Remove(Tag item);
    }
}
