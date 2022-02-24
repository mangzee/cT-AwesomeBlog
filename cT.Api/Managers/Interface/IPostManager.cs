using cT.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cT.Api.Managers.Interface
{
    /// <summary>
    /// Interface for post-related business logic methods
    /// </summary>
    public interface IPostManager
    {
        void Save(PostDetailsModel postDetails);
        PostDetailsModel Get(int id);
        ICollection<PostListItemModel> List();
        void Remove(int id);
    }
}
