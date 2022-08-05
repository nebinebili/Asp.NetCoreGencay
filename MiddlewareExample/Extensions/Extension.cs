using Microsoft.AspNetCore.Builder;
using MiddlewareExample.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExample.Extensions
{
    static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<HelloMiddleware>();
        }

        // Middlewear-lar IApplicationBuilder return edir bunun ucun funskiya return o olmalidir.
    }
}
