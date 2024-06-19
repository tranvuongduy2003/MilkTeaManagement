namespace MilkTeaManagement.SignalR.Extentions
{
    public static class ApplicationExtensions
    {
        public static void UseInfrastructure(this WebApplication app, string appCors)
        {
            app.MapControllers();
            app.UseErrorWrapping();
            app.UseCors(appCors);
            app.MapControllers();

            // Hubs
            app.MapHub<ChatHub>("/Chat");
        }
    }
}
