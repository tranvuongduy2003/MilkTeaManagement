using Serilog;

namespace MilkTeaManagement.SignalR.Helpers
{
    public static class Serilogger
    {
        public static Action<HostBuilderContext, LoggerConfiguration> Configure =>
            (context, configuration) =>
            {
                var environmentName = context.HostingEnvironment.EnvironmentName ?? "Development";

                configuration
                    .WriteTo.Debug()
                    .WriteTo.Console(outputTemplate:
            "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}")
                    .Enrich.FromLogContext()
                    .Enrich.WithMachineName()
                    .Enrich.WithProperty("Environment", environmentName)
                    .ReadFrom.Configuration(context.Configuration);
            };
    }
}
