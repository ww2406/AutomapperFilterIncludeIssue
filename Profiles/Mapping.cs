using AutoMapper;
using AutomapperProjectInclude.DTOs;
using AutomapperProjectInclude.Models;

namespace AutomapperProjectInclude.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Blog, BlogDTO>();
            CreateMap<Post, PostDTO>();
            CreateMap<Author, AuthorDTO>();
        }
    }
}