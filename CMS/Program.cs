using CMS.Data;
using Microsoft.EntityFrameworkCore;
using CMS.Interfaces;
using CMS.GraphQL.Query;
using DataServices;
using CMS.DataServices;
using CMS.GraphQL.Mutation;
using DataServices.Processors;
using DataServices.Interfaces;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<ApplicationDbContext>(
    opt => opt.UseSqlServer(configuration.GetConnectionString("SqlServer"))
    .EnableSensitiveDataLogging()
);

builder.Services.AddControllers();
builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<ApplicationDbContext>(DbContextKind.Synchronized)
    .AddQueryType(q => q.Name("Query"))
    .AddType<ContentTypeQuery>()
    .AddType<OrganizationQuery>()
    .AddMutationType(m => m.Name("Mutation"))
    .AddType<OrganizationMutation>()
    .AddType<ContentTypeMutation>()
    .AddMutationConventions(applyToAllMutations: true)
    .AddProjections()
    .AddSorting()
    .AddFiltering();

// Factory + Field Processors
builder.Services.AddScoped<FieldProcessorFactory>();
builder.Services.AddScoped<FileFieldProcessor>()
        .AddScoped<IFieldProcesssorService, FileFieldProcessor>(s => s.GetService<FileFieldProcessor>());
builder.Services.AddScoped<ListFieldProcessor>()
        .AddScoped<IFieldProcesssorService, ListFieldProcessor>(s => s.GetService<ListFieldProcessor>());
builder.Services.AddScoped<PlainFieldProcessor>()
        .AddScoped<IFieldProcesssorService, PlainFieldProcessor>(s => s.GetService<PlainFieldProcessor>());

// ---
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