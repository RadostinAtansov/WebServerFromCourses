﻿

using MyServer;
using System.Threading.Tasks;

namespace WebServerFromCourses
{
    public class StartUp
    {
        public static async Task Main()
        {

            var server = new HttpServer("127.0.0.1", 9090);

            await server.Start();
        }
    }
}