using AutomapperProjectInclude.Models;

namespace AutomapperProjectInclude.DTOs
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorDTO Author { get; set; }
    }
}