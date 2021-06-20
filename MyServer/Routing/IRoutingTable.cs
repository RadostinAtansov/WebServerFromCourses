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
        IRoutingTable Map(string url, HttpMethod method, HttpRespose respose);

        IRoutingTable MapGet(string url, HttpRespose respose);
    }
}
