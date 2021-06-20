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

        public HttpResponse Dogs() => View();

        public HttpResponse Bunnies() => View("Rabbits");

        public HttpResponse Turtels() => View("Animals/Wild/LotsOfTurtles");

    }
}
