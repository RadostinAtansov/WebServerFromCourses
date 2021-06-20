namespace MyServer.Responses
{
    using MyServer.Common;
    using MyServer.Http;
    using System.Text;

    public class TextResponse : ContentResponse
    {
        public TextResponse(string text)
            : base(text, "text/plain; charset=UTF-8")
        {

        }
    }
}
