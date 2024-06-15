using Common.Logging;
using Product.API.Extensions;
using Product.API.Persistence;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Information("Starting Product API up");

try
{
    
    builder.Host.UseSerilog(Serilogger.Configure);
    builder.Host.AddAppConfigurations();
    // Add services to the container.
    builder.Services.AddInfrastructure(builder.Configuration);

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    
    app.UseInfrastructure();
    app.MigrateDatabase<ProductContext>((context, _) =>
        {
            ProductContextSeed.SeedProductAsync(context, Log.Logger).Wait();
        })
        .Run();
}
catch (Exception e)
{
    string type = e.GetType().Name;
    if (type.Equals("StopTheHostException", StringComparison.Ordinal))
    {
        throw;
    }
    Log.Fatal(e, $"Unhandled exception: {e.Message}");
}
finally
{
    Log.Information("Shut down Product API complete");
    Log.CloseAndFlush();
}
