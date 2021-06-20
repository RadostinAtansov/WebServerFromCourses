namespace MyServer.Controllers
{
    using MyServer.Http;
    using MyServer.Responses;
    using System.Runtime.CompilerServices;

    public abstract class ControllerHandMade
    {

        protected ControllerHandMade(HttpRequest request)
            => this.Request = request;

        protected HttpRequest Request { get; private set; }

        protected HttpResponse Text(string text)
            => new TextResponse(text);

        protected HttpResponse Html(string html)
            => new HtmlResponse(html);

        protected HttpResponse Redirect(string location)
            => new RedirectResponse(location);

        protected HttpResponse View([CallerMemberName] string viewName = "")
            => new ViewResponse(viewName, this.GetControllerName());

        private string GetControllerName()
            => this.GetType().Name.Replace(nameof(ControllerHandMade), string.Empty);

    }
}
