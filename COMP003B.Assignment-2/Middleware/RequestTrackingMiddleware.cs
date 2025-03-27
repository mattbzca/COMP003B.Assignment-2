namespace COMP003B.Assignment_2.Middleware
{
    public class RequestTrackingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTrackingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");
            await _next(context);
            Console.WriteLine($"[Response] {context.Response.StatusCode}");
        }
    }
}
