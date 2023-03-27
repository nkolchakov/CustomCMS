using CMS.Data;
using Microsoft.EntityFrameworkCore;
using CMS.Interfaces;
using CMS.GraphQL.Query;
using DataServices;
using CMS.DataServices;
using CMS.GraphQL.Mutation;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("SqlServer"))
           .EnableSensitiveDataLogging()

    );

builder.Services.AddControllers();
builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<ApplicationDbContext>(DbContextKind.Pooled)
    .AddQueryType(q => q.Name("Query"))
    .AddType<ContentTypeQuery>()
    .AddType<OrganizationQuery>()
    .AddMutationType(m => m.Name("Mutation"))
    .AddType<OrganizationMutation>()
    .AddMutationConventions(applyToAllMutations: true)
    .AddProjections()
    .AddSorting()
    .AddFiltering();


builder.Services.AddScoped<IContentService, ContentService>();
builder.Services.AddScoped<IOrganizationService, OrganizationService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.MapControllers();
app.UseCors(builder => builder
                    .AllowAnyHeader()
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
);
app.MapGraphQL(path: "/graphql");
app.Run();