using System.Web;

namespace EPiServer.Templates.Alloy.LanguageTool.Infrastructure.Bootstrap
{
    public class NullHttpContext : HttpContextBase
    {
        private readonly HttpRequestBase _request = new NullHttpRequest();
        private readonly HttpResponseBase _response = new NullHttpResponse();

        public override HttpRequestBase Request
        {
            get { return _request; }
        }

        public override HttpResponseBase Response
        {
            get { return _response; }
        }
    }
}
