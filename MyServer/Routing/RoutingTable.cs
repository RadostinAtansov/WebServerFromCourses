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

        private readonly Dictionary<HttpMethod, Dictionary<string, Func<HttpRequest, HttpResponse>>> routes;

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
            HttpResponse response)
        {
            Guard.AgainstNull(response, nameof(response));

            return this.Map(method, path, request => response);
        }

        public IRoutingTable Map(HttpMethod method, string path, Func<HttpRequest, HttpResponse> resposeFunction)
        {
            Guard.AgainstNull(path, nameof(path));
            Guard.AgainstNull(resposeFunction, nameof(resposeFunction));

            this.routes[HttpMethod.Get][path.ToLower()] = resposeFunction;

            return this;
        }

        public IRoutingTable MapGet(
            string path,
            HttpResponse response)
            => MapGet(path, request => response);


        public IRoutingTable MapGet(string path, Func<HttpRequest, HttpResponse> resposeFunction)
            => Map(HttpMethod.Get, path, resposeFunction);

        public IRoutingTable MapPost(
            string path,
            HttpResponse response)
            => MapPost(path, request => response);

        public IRoutingTable MapPost(
            string path, 
            Func<HttpRequest, HttpResponse> resposeFunction)
            => Map(HttpMethod.Get, path, resposeFunction);

        public HttpResponse MatchRequest(HttpRequest request) 
        {

            var requestMethod = request.Method;
            var requestUrl = request.Path.ToLower();

            if (!this.routes.ContainsKey(requestMethod)
                || !this.routes[requestMethod].ContainsKey(requestUrl))
            {
                return new NotFoundResponse();
            }

            var responseFunc = this.routes[requestMethod][requestUrl];

            return responseFunc(request);
        }
    }
}
