using AutoMapper;
using cT.Api.Managers.Interface;
using cT.Api.Models;
using cT.Api.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cT.Api.Managers
{
    /// <summary>
    /// Implementation for post-related business logic methods
    /// </summary>
    public class PostManager : IPostManager
    {
        private IPostRepository _postRepository;

        public PostManager(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void Save(PostDetailsModel postDetails)
        {
            if (string.IsNullOrEmpty(postDetails.Title))
            {
                throw new ArgumentException("Post title is empty");
            }

            if (string.IsNullOrEmpty(postDetails.Content))
            {
                throw new ArgumentException("Post content is empty");
            }

            Repositories.Entities.Post savedEntity = null;

            if (postDetails.Id > 0)
            {
                //TODO : please add implementation here
                //Save the data to an existing Post Entity with related tags
                //Please keep in mind that if there is no POST data with the related Id then throw not found response
                //For saving Tags, make sure if its a new tag not available in the database then create a new one and link it to post entity before saving
                //else use the existing Tag with the same name from the database
                // For untagging please look into the TagManager
            }
            else
            {
                savedEntity = Mapper.Map<Repositories.Entities.Post>(postDetails);
                //TODO : please add implementation here
                //Insert the new data into database
                //For saving Tags, make sure if its a new tag not available in the database then create a new one and link it to post entity before saving
                //else use the existing Tag with the same name from the database
            }

            postDetails.Id = savedEntity.Id;
        }

        public PostDetailsModel Get(int id)
        {
            throw new NotImplementedException();
            //TODO : please add implementation here
            // method should call repository, get what's required,
            // map to return object via AutoMapper (take a look at its usage in other methods in this class)
            // be careful with Tags property - please map it manually if not possible through Automapper
            // and throw ArgumentException when postId is not valid
        }

        public ICollection<PostListItemModel> List()
        {
            return Mapper.Map<List<PostListItemModel>>(_postRepository.AsQuery());
        }

        public void Remove(int id)
        {
            var post = _postRepository.AsQuery().FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                throw new ArgumentException(string.Format("Specified post (id={0}) does not exist", id));
            }
            //TODO: please add implementation here
            //Implement Delete functionality of post based on Id
            //Related Tags should be deleted if it is not tied with any other posts
            throw new NotImplementedException();
        }
    }
}