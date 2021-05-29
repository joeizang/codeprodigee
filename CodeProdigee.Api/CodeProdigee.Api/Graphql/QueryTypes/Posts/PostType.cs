using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeProdigee.Api.Data;
using CodeProdigee.Api.DomainModels;
using HotChocolate;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace CodeProdigee.Api.Graphql.QueryTypes.Posts
{
    public class PostType : ObjectType<Post>
    {
        protected override void Configure(IObjectTypeDescriptor<Post> descriptor)
        {
            descriptor
                .Field(p => p.PostAuthor)
                .ResolveWith<Resolver>(p => p.GetPosts(default!, default!))
                .UseDbContext<CodeProdigeeContext>()
                .UseProjection()
                .UseFiltering()
                .UseSorting()
                .UsePaging()
                .Description("Gets Author of this Post");
            descriptor
                .Field(p => p.Resources)
                .ResolveWith<Resolver>(p => p.GetPostsResources(default!, default!))
                .UseDbContext<CodeProdigeeContext>()
                .UseProjection()
                .UseFiltering()
                .UseSorting()
                .UsePaging()
                .Description("Gets resources and author that goes with a post");
            descriptor
                .Field(p => p.Comments)
                .ResolveWith<Resolver>(p => p.GetPostsComments(default!, default!))
                .UseDbContext<CodeProdigeeContext>()
                .UseProjection()
                .UseFiltering()
                .UseSorting()
                .UsePaging()
                .Description("Gets resources and author that goes with a post");
            descriptor
                .Field(p => p.Body)
                .Type<NonNullType<StringType>>();
            descriptor
                .Field(p => p.Title)
                .Type<NonNullType<StringType>>();
            descriptor
                .Field(p => p.IsDeleted)
                .Ignore();
            descriptor
                .Field(p => p.UpdatedBy)
                .Ignore();
            descriptor
                .Field(p => p.UpdatedOn)
                .Ignore();
        }

        class Resolver
        {
            public IQueryable<Post> GetPosts(Post post, [ScopedService] CodeProdigeeContext context)
            {
                return context.Posts.AsNoTracking()
                    .Include(p => p.PostAuthor);
            }

            public IQueryable<Post> GetPostsResources(Post post, [ScopedService] CodeProdigeeContext context)
            {
                return context.Posts.AsNoTracking()
                    .Include(p => p.Resources)
                    .Include(p => p.PostAuthor);
            }
            public IQueryable<Post> GetPostsComments(Post post, [ScopedService] CodeProdigeeContext context)
            {
                return context.Posts.AsNoTracking()
                    .Include(p => p.Comments)
                    .Include(p => p.PostAuthor);
            }
        }
    }
}
