using CMS.Data;
using Microsoft.EntityFrameworkCore;
using HotChocolate.Data;
using CMS.Interfaces;
using CMS.DataServices;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("SqlServer"))
    );

builder.Services.AddControllers();
builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<ApplicationDbContext>(DbContextKind.Pooled)
    .AddQueryType<Query>()
    .AddProjections()
    .AddSorting()
    .AddFiltering();


builder.Services.AddScoped<IContentTypeService, ContentTypeService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.MapControllers();
app.MapGraphQL(path: "/graphql");
app.Run();