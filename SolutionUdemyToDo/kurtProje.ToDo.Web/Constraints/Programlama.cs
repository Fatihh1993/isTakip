using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kurtProje.ToDo.Web.Constraints
{
    public class Programlama : IRouteConstraint
    {
        public List<string> programlamaDilleri = new List<string> { "csharyp", "java", "php" };
        public bool Match(HttpContext httpContext, IRouter route, string routeKey,
           RouteValueDictionary values, RouteDirection routeDirection)
        {
           return programlamaDilleri.Contains(values[routeKey].ToString().ToLower());
        }
    }
}
