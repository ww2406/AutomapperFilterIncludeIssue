using System;
using AutomapperProjectInclude.Models;
using Microsoft.EntityFrameworkCore;

namespace AutomapperProjectInclude.Contexts
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }

        public BloggingContext()
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=test.db");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                Id = 1
            });
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    Name = "Test1"
                }, new Author
                {
                    Id = 2,
                    Name = "Test2"
                });
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    BlogId = 1,
                    AuthorId = 1,
                    Title = "Should be returned"
                },
                new Post
                {
                    Id = 2,
                    BlogId = 1,
                    AuthorId = 2,
                    Title = "Should not be returned"
                });
        }
    }
}