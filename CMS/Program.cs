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

//using (var scope = app.Services.CreateScope())
//{
//    var service = scope.ServiceProvider;
//    var dbFactory = service.GetService<IDbContextFactory<ApplicationDbContext>>();

//    var gameEntityId = Guid.Parse("181BB903-58D4-4C35-9AD1-C048E9ACCAB1");
//    FormattableString formattedSql = $@"
//		WITH CHAIN
//		AS (
//			SELECT ChildId as c
//			FROM dbo.ContentTypeReferences as c2c
//			WHERE ParentId = {gameEntityId.ToString()}
//			UNION ALL
//			SELECT ChildId FROM CHAIN, dbo.ContentTypeReferences as c2c
//			WHERE CHAIN.c = c2c.ParentId
//		)
//		SELECT c FROM CHAIN";

//    using (var context = dbFactory.CreateDbContext())
//    {

//        List<Guid> depIds = context.Database.SqlQuery<Guid>(formattedSql).ToList();
//        var gameEntity = context.ContentTypes
//            .Include(e => e.BasicFields)
//            .Include(e => e.Children)
//            .FirstOrDefault(e => e.Id == gameEntityId);

//        var dependencies = context.ContentTypes
//            .Where(c => depIds.Any(d => d == c.Id))
//            .Include(e => e.Children)
//            .Include(e => e.Parents)
//            .ToList();
//    }


//}

app.MapControllers();
app.MapGraphQL(path: "/graphql");
app.Run();