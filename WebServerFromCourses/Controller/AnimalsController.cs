namespace WebServerFromCourses.Controller
{
    using MyServer;
    using MyServer.Http;
    using MyServer.Responses;
    using MyServer.Controllers;

    public class AnimalsController : ControllerHandMade
    {
        public AnimalsController(HttpRequest request) 
            : base(request)
        {
        }

        public HttpResponse Cats()
        {
            const string nameKey = "name";

            var query = this.Request.Query;

            var catName = query.ContainsKey(nameKey)
              ? query[nameKey]
              : "the cats";

            var result = $"<h1>Hello from {catName}</h1>";


            return Html(result);
        }

        public HttpResponse Dogs()
        {
            return Html("<h1>Hello from the dogs</h1>");
        }
    }
}
