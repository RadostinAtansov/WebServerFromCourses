namespace WebServerFromCourses
{
    using MyServer;
    using System.Threading.Tasks;
    using WebServerFromCourses.Controller;

    public class StartUp
    {
        public static async Task Main()
           =>  await new HttpServer(routtes => routtes
                .MapGet<HomeController>("/", c => c.Index())
               .MapGet("/", request => new HomeController(request).Index())
               .MapGet("/Cats", request => new AnimalsController(request).Cats())
               .MapGet("/Dogs",request =>  new AnimalsController(request).Dogs()))
            .Start();
        
    }
}
