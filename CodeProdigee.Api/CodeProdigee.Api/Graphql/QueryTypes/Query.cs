using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeProdigee.Api.Data;
using CodeProdigee.Api.DomainModels;
using HotChocolate;

namespace CodeProdigee.Api.Graphql.QueryTypes
{
    public class Query
    {
        public IQueryable<Post> GetPost([Service] CodeProdigeeContext context)
        {
            return context.Posts;
        }
    }
}
