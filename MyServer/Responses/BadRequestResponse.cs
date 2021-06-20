
namespace MyServer.Responses
{
    using MyServer.Http;

    public class BadRequestResponse : HttpResponse
    {
        public BadRequestResponse() 
            : base(HttpStatusCode.BadRequest)
        {
        }
    }
}
