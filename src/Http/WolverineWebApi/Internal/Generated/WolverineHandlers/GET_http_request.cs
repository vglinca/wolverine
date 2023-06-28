// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_http_request
    public class GET_http_request : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _options;

        public GET_http_request(Wolverine.Http.WolverineHttpOptions options) : base(options)
        {
            _options = options;
        }



        public override System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var httpContextEndpoints = new WolverineWebApi.HttpContextEndpoints();
            httpContextEndpoints.UseHttpRequest(httpContext.Request);
            // Wolverine automatically sets the status code to 204 for empty responses
            httpContext.Response.StatusCode = 204;
            return System.Threading.Tasks.Task.CompletedTask;
        }

    }

    // END: GET_http_request
    
    
}

