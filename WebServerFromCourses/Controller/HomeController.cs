namespace WebServerFromCourses.Controller
{
    using MyServer;
    using MyServer.Http;
    using MyServer.Responses;
    using MyServer.Controllers;


    public class HomeController : ControllerHandMade
    {

        public HomeController(HttpRequest request) 
            : base(request)
        {

        }

        public HttpResponse Index()
            =>  Text("Hello from Radul");

        public HttpResponse LocalRedirect() => Redirect("Cats");

        public HttpResponse ToSoftUni() => Redirect("https://softuni.bg");

    }
}
