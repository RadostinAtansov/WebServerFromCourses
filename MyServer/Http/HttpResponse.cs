using MyServer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServer.Http
{
    public abstract class HttpResponse
    {

        public HttpResponse(HttpStatusCode statusCode)
        {
            this.StatusCode = statusCode;

            this.Headers.Add("Server", "My Web Server");
            this.Headers.Add("Date", $"{DateTime.UtcNow:r}");

        }

        public HttpStatusCode StatusCode { get; protected set; }

        public HttpHeaderCollection Headers { get; } = new HttpHeaderCollection();

        public string Content { get; protected set; }

        protected virtual string GetContent()
        { 
            return null; 
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"HTTP/1.1 {(int)this.StatusCode} {this.StatusCode}");

            foreach (var header in this.Headers)
            {
                result.AppendLine(header.ToString());
            }

            if (!string.IsNullOrEmpty(this.Content))
            {
                result.AppendLine();
                result.Append(this.Content);
            }

            return result.ToString();

        }

        protected void PrepareContent(string content, string contentType)
        {

            Guard.AgainstNull(content, nameof(content));
            Guard.AgainstNull(contentType, nameof(contentType));

            var contentLength = Encoding.UTF8.GetByteCount(content).ToString();

            this.Headers.Add("Content-Type", contentType);
            this.Headers.Add("Content-Length", contentLength);
        }

    }
}
