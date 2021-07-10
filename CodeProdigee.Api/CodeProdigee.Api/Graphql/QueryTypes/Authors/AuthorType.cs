using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeProdigee.Api.Data;
using CodeProdigee.Api.DomainModels;
using HotChocolate;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace CodeProdigee.Api.Graphql.QueryTypes.Authors
{
    public class AuthorType : ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            descriptor
                .Field(a => a.AuthorPosts)
                .ResolveWith<Resolvers>(a => a.GetAuthors(default!, default!))
                .UseDbContext<CodeProdigeeContext>()
                .Description("Returns all posts by an author");
            descriptor
                .Field(a => a.Firstname)
                .Ignore();
            descriptor
                .Field(a => a.Lastname)
                .Ignore();
            descriptor
                .Field(a => a.Othernames)
                .Ignore();

        }


        class Resolvers
        {
            public IQueryable<Author> GetAuthors(Author author, [ScopedService] CodeProdigeeContext context)
            {
                return context.Authors.AsNoTracking()
                            .Include(a => a.AuthorPosts);
            }
        }
    }
}
