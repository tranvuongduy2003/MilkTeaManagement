using MilkTeaManagement.SignalR.Helpers;

namespace MilkTeaManagement.SignalR.Extentions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorWrapping(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorWrappingMiddleware>();
        }
    }
}