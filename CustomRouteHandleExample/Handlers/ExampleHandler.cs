using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomRouteHandleExample.Handlers
{
    public class ExampleHandler
    {
        public RequestDelegate Handler()
        {
            return async c =>
            {
               await c.Response.WriteAsync("hello world");
            };
        }
    }
}
