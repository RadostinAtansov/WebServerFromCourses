using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServer.Routing
{

    using MyServer.Http;

    public interface IRoutingTable
    {
        IRoutingTable Map(HttpMethod method, string path, HttpResponse respose);

        IRoutingTable Map(HttpMethod method, string path, Func<HttpRequest, HttpResponse> resposeFunction);

        IRoutingTable MapGet(string path, HttpResponse respose);

        IRoutingTable MapGet(string path, Func<HttpRequest, HttpResponse> resposeFunction);

        IRoutingTable MapPost(string path, HttpResponse response);

        IRoutingTable MapPost(string path, Func<HttpRequest, HttpResponse> resposeFunction);
    }
}
