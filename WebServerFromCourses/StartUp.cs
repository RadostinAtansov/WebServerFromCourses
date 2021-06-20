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
               .MapGet("/Cats", request =>
               {
                   const string nameKey = "name";

                   var query = request.Query;

                   var catName = query.ContainsKey("Name")
                     ? query["Name"]
                     : "the cats";

                   var result = $"<h1>Hello from radku</h1>";


                   return new HtmlResponse(result);
               })
               .MapGet("/Dogs", new HtmlResponse("<h1>Hello from the dogs</h1>")))
            .Start();
        
    }
}
