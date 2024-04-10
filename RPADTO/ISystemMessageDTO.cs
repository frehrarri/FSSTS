using System.Net;

namespace RPADTO
{
    public interface ISystemMessageDTO
    {
        public HttpResponseMessage HttpResponseMessage { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
