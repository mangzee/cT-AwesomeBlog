using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cT.Api.Repositories.Interface
{
    public interface ICommonRepository<T> where T: IEntity
    {
        IQueryable<T> AsQuery();
        void Add(T item);
        void Remove(T item);
    }
}
