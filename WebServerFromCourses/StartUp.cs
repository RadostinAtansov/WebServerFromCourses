namespace WebServerFromCourses
{
    using MyServer;
    using MyServer.Responses;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static async Task Main()
           =>  await new HttpServer(routtes => routtes
               .MapGet("/", new TextResponse("Hello from Radul"))
               .MapGet("/Cats", new HtmlResponse("<h1>Hello from the cats</h1>"))
               .MapGet("/Dogs", new HtmlResponse("<h1>Hello from the dogs</h1>")))
            .Start();
        
    }
}
