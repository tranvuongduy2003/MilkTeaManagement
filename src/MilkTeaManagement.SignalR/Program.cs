using MilkTeaManagement.SignalR.Extentions;
using MilkTeaManagement.SignalR.Helpers;
using Serilog;

var AppCors = "AppCors";

var builder = WebApplication.CreateBuilder(args);

Log.Information("Starting up");

try
{
    builder.Host.UseSerilog(Serilogger.Configure);
    builder.Host.AddAppConfigurations();

    builder.Services.AddInfrastructure(builder.Configuration, AppCors);

    var app = builder.Build();

    app.UseInfrastructure(AppCors);

    app.Run();
}
catch (Exception ex)
{
    string type = ex.GetType().Name;
    if (type.Equals("StopTheHostException", StringComparison.Ordinal)) throw;

    Log.Fatal(ex, $"Unhandled exception: {ex.Message}");
}
finally
{
    Log.Information("Shut down complete");
    Log.CloseAndFlush();
}