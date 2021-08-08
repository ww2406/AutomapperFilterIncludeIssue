namespace AutomapperProjectInclude.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}