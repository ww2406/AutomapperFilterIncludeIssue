using System.Collections.Generic;

namespace AutomapperProjectInclude.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Post> Posts { get; set; }
    }
}