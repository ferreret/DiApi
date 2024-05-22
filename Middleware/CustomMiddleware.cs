using DiApi.Utility;

namespace DiApi.Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IOperationTransient _transient;
        
        private readonly IOperationSingleton _singleton;
        public CustomMiddleware(RequestDelegate next,                                 
                                IOperationTransient transient,    
                                IOperationSingleton singleton)
        {
            _next = next;
            _transient = transient;            
            _singleton = singleton;
        }

        public async Task Invoke(HttpContext context, IOperationScoped scoped)
        {
            Console.WriteLine($"Middleware; TransientId {_transient.OperationId} ScopeId {scoped.OperationId} SingletonId {_singleton.OperationId}");   
            await _next(context);
        }
    }

    public static class CustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware>();
        }
    }
}
