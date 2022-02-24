using cT.Api.Repositories.Entities;
using cT.Api.Repositories.Interface;
using System.Linq;

namespace cT.Api.Repositories
{
    /// <summary>
    /// Implementation for storage abstraction (repository) of tags bound to in-memory repository
    /// </summary>
    public class TagRepository : InMemoryRepository<Tag>, ITagRepository
    {
    }
}