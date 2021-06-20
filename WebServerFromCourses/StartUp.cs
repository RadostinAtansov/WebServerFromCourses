namespace WebServerFromCourses
{
    using MyServer;
    using System.Threading.Tasks;
    using WebServerFromCourses.Controller;
    using MyServer.Controllers;

    public class StartUp
    {
        public static async Task Main()
           =>  await new HttpServer(routtes => routtes
               .MapGet<HomeController>("/", c => c.Index())
               .MapGet<HomeController>("/ToCats", c => c.LocalRedirect())
               .MapGet<HomeController>("/Softuni", c => c.ToSoftUni())
               .MapGet<AnimalsController>("/Cats", c => c.Cats())
               .MapGet<AnimalsController>("/Dogs", c => c.Dogs())
               .MapGet<AnimalsController>("/Turtles", c => c.Turtels())
           ).Start();
        
    }
}
