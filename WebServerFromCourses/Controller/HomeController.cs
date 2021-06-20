namespace WebServerFromCourses.Controller
{
    using MyServer;
    using MyServer.Http;
    using MyServer.Responses;

    public class HomeController : ControllerHandMade
    {

        public HomeController(HttpRequest request) 
            : base(request)
        {

        }

        public HttpResponse Index()
            =>  Text("Hello from Radul");


    }
}
