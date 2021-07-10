using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CodeProdigee.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using CodeProdigee.Api.Graphql.QueryTypes;
using GraphQL.Server.Ui.Voyager;
using CodeProdigee.Api.Graphql.QueryTypes.Authors;
using CodeProdigee.Api.Graphql.QueryTypes.Posts;

namespace CodeProdigee.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddPooledDbContextFactory<CodeProdigeeContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"))
                    .EnableSensitiveDataLogging();
            });
            services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddType<AuthorType>()
                .AddType<PostType>()
                .AddProjections()
                .AddFiltering()
                .AddSorting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
            var gqlOptions = new VoyagerOptions()
            {
                GraphQLEndPoint = "/graphql"
            };
            app.UseGraphQLVoyager(gqlOptions, "/graphql-voyager");
        }
    }
}
