using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteExample.Constraints
{
    public class CustomConstraint : IRouteConstraint
    {
        public bool Match(
            HttpContext httpContext, 
            IRouter route, 
            string routeKey, 
            RouteValueDictionary values, 
            RouteDirection routeDirection)
        {
            var idvalues = values[routeKey];
            return true;
        }
    }
}
