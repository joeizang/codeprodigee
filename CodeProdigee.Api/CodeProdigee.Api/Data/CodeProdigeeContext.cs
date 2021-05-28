using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeProdigee.Api.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace CodeProdigee.Api.Data
{
    public class CodeProdigeeContext : DbContext
    {
        public CodeProdigeeContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Commentator> Commentators { get; set; }

        public DbSet<Resource> Resources { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Comment>()
                .HasMany(c => c.Replies)
                .WithOne(r => r.OriginalComment)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Post>()
                .HasOne(p => p.PostAuthor)
                .WithMany(a => a.AuthorPosts)
                .HasForeignKey(p => p.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Post>()
                .HasMany(p => p.Resources)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Commentator>()
                .HasMany(c => c.Comments)
                .WithOne(c => c.Commentator)
                .HasForeignKey(c => c.CommentatorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
