using System.Diagnostics;

namespace MVCAssig01.MiddleWares
{
    public class RequestTimeMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

     

        public async Task InvokeAsync(HttpContext context)
        {
            var stopWatch = Stopwatch.StartNew();
            await _next.Invoke(context);
            stopWatch.Stop();
            Console.WriteLine($"{context.Request.Path}--->{stopWatch.ElapsedMilliseconds} ms");
        }



    }
}
