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

        IRoutingTable MapGet(string path, HttpResponse respose);
    }
}
