﻿using System.Net;

namespace DTO
{
    public class BaseDTO : ISystemMessageDTO, ILogDTO
    {
        public BaseDTO()
        {
            ValidationErrors = new List<string>();
        }

        //MetaData
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        //System Messages
        public HttpResponseMessage HttpResponseMessage { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public bool Authorized { get; set; }

        //Logging
        public string Message { get; set; }
        public string InnerException { get; set; }
        public string StackTrace { get; set; }
        public List<string> ValidationErrors { get; set; }
    }
}
