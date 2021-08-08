using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutomapperProjectInclude.Contexts;
using AutomapperProjectInclude.DTOs;
using AutomapperProjectInclude.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomapperProjectInclude.Controllers
{
    [ApiController]
    public class TestController
    {
        private readonly BloggingContext _ctx;
        private readonly IMapper _mapper;

        public TestController(BloggingContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        
        [HttpGet("raw")]
        public List<BlogDTO> GetRawBlog()
        {
            var rec = _mapper.Map<List<BlogDTO>>(_ctx.Blogs
                .Include(x => x.Posts.Where(x => x.Author.Name=="Test1"))
                .ThenInclude(x => x.Author)
                .ToList());
            return rec;
        }
        
        [HttpGet("project")]
        public List<BlogDTO> GetProjectBlog()
        {
            var rec = _ctx.Blogs
                .Include(x => x.Posts.Where(x => x.Author.Name=="Test1"))
                .ThenInclude(x => x.Author)
                .ProjectTo<BlogDTO>(_mapper.ConfigurationProvider)
                .ToList();
            return rec;
        }
    }
}