using AutoMapper;
using cT.Api.Models;
using cT.Api.Repositories.Entities;

namespace cT.Api
{
    public static class AutoMapperConfiguration
    {
        public static void Init()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostDetailsModel>();

                cfg.CreateMap<PostDetailsModel, Post>();

                cfg.CreateMap<Post, PostListItemModel>()
               .ForMember(dest => dest.ShortDescription, opt => opt.MapFrom(src =>
                  string.IsNullOrEmpty(src.Content)
                  ? src.Content
                  : string.Format("{0}.....", src.Content.Substring(0, System.Math.Min(src.Content.Length, 50))))); // getting 50 first symbols of a post from post content
            }
            );
        }
    }
}