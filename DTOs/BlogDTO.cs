using System.Collections.Generic;

namespace AutomapperProjectInclude.DTOs
{
    public class BlogDTO
    {
        public int Id { get; set; }
        public List<PostDTO> Posts { get; set; }
    }
}