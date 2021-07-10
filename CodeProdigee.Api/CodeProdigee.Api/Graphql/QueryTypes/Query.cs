using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeProdigee.Api.Data;
using CodeProdigee.Api.DomainModels;
using HotChocolate;
using HotChocolate.Data;

namespace CodeProdigee.Api.Graphql.QueryTypes
{
    public class Query
    {
        [UseDbContext(typeof(CodeProdigeeContext))]
        public IQueryable<Post> GetPost([ScopedService] CodeProdigeeContext context)
        {
            return context.Posts;
        }

        [UseDbContext(typeof(CodeProdigeeContext))]
        public IQueryable<Author> GetAuthor([Service] CodeProdigeeContext context)
        {
            return context.Authors;
        }

        [UseDbContext(typeof(CodeProdigeeContext))]
        public IQueryable<Comment> GetComment([Service] CodeProdigeeContext context)
        {
            return context.Comments;
        }

        [UseDbContext(typeof(CodeProdigeeContext))]
        public IQueryable<Commentator> GetCommentator([Service] CodeProdigeeContext context)
        {
            return context.Commentators;
        }

        [UseDbContext(typeof(CodeProdigeeContext))]
        public IQueryable<Resource> GetResource([Service] CodeProdigeeContext context)
        {
            return context.Resources;
        }
    }
}
