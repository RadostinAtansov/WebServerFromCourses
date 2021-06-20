
namespace MyServer.Responses
{
    using MyServer.Http;

    public class NotFoundResponse : HttpResponse
    {
        public NotFoundResponse() 
            : base(HttpStatusCode.NotFound)
        {
        }
    }
}
