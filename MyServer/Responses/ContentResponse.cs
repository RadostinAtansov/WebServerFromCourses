namespace MyServer.Responses
{

    using MyServer.Common;
    using MyServer.Http;


    public class ContentResponse : HttpResponse
    {
        public ContentResponse(string content, string contentType)
           : base(HttpStatusCode.OK)
        {
            Guard.AgainstNull(content, nameof(content));
            Guard.AgainstNull(contentType, nameof(contentType));

            this.PrepareContent(content, contentType);
        }
    }
}
