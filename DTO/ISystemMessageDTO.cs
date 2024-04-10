using System.Net;

namespace DTO
{
    public interface ISystemMessageDTO
    {
        public HttpResponseMessage HttpResponseMessage { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
