using MyServer.Common;
using MyServer.Http;
using System;
using System.Collections.Generic;
using MyServer.Responses;

namespace MyServer.Routing
{

    using MyServer.Responses;

    public class RoutingTable : IRoutingTable
    {

        private readonly Dictionary<HttpMethod, Dictionary<string, HttpResponse>> routes;

        public RoutingTable() => this.routes = new()
        {
            [HttpMethod.Get] = new(),
            [HttpMethod.Post] = new(),
            [HttpMethod.Put] = new(),
            [HttpMethod.Delete] = new(),
        };

        public IRoutingTable Map(
            HttpMethod method, 
            string path, 
            HttpResponse respose)
        {
            Guard.AgainstNull(path, nameof(path));
            Guard.AgainstNull(respose, nameof(respose));

            this.routes[HttpMethod.Get][path] = respose;

            return this;
        }

        public IRoutingTable MapGet(
            string path,
            HttpResponse response)
            => Map(HttpMethod.Get, path, response);

        public IRoutingTable MapPost(
            string path,
            HttpResponse response)
            => Map(HttpMethod.Get, path, response);


        public HttpResponse MatchRequest(HttpRequest request) 
        {

            var requestMethod = request.Method;
            var requestUrl = request.Path;

            if (!this.routes.ContainsKey(requestMethod)
                || !this.routes[requestMethod].ContainsKey(requestUrl))
            {
                return new NotFoundResponse();
            }

            return this.routes[requestMethod][requestUrl];
        }
    }
}
