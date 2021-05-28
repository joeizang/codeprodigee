using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeProdigee.Api.Graphql.QueryTypes;
using Microsoft.Extensions.DependencyInjection;

namespace CodeProdigee.Api.Extensions
{
    public static class CodeProdigeeExtensions
    {

        public static void AddHotChocolate(this IServiceCollection services)
        {
            services.AddGraphQLServer()
                .AddQueryType<Query>(); 
        }
    }
}
