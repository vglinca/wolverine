// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using WolverineWebApi;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_notbody
    public class POST_notbody : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _options;
        private readonly WolverineWebApi.Recorder _recorder;

        public POST_notbody(Wolverine.Http.WolverineHttpOptions options, WolverineWebApi.Recorder recorder) : base(options)
        {
            _options = options;
            _recorder = recorder;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var attributeEndpoints = new WolverineWebApi.AttributeEndpoints();
            var result_of_PostNotBody = attributeEndpoints.PostNotBody(_recorder);
            await WriteString(httpContext, result_of_PostNotBody);
        }

    }

    // END: POST_notbody
    
    
}

