namespace MyServer.Responses
{
    using MyServer.Common;
    using MyServer.Http;
    using System.Text;

    public class TextResponse : HttpRespose
    {

        public TextResponse(string text, string contentType)
            : base(HttpStatusCode.OK)
        {
            Guard.AgainstNull(text);

            var contentLength = Encoding.UTF8.GetByteCount(text).ToString();

            this.Headers.Add("Content-Type", contentLength);
            this.Headers.Add("Content-Length", contentLength);

            this.Content = text;
        }

        public TextResponse(string text)
            : this(text, "text/plain; charset=UTF-8")
        {

        }
    }
}
