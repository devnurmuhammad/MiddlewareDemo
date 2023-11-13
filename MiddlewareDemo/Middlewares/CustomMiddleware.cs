namespace MiddlewareDemo.Middlewares
{
    public class CustomMiddleware
    {
        private RequestDelegate _requestDelegate;

        public CustomMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path;
            if (path == "/home")
            {
                await context.Response.WriteAsync("Welcome to Home page!");
            }
            else if (path == "/about")
            {
                await context.Response.WriteAsync("Welcome to About page!");
            }
            else
            {
                context.Response.StatusCode = 404;
            }
            //return Task.CompletedTask;
        }
    }
}
