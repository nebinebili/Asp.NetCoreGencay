using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExample.Middlewares
{
    public class HelloMiddleware
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            /// Custom isler....

            Console.WriteLine("Salam aleykum");
            await _next.Invoke(httpContext);
            Console.WriteLine("Aleykum Salam");
        }
    }
}
