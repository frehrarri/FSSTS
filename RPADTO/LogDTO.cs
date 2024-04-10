namespace RPADTO
{
    public class LogDTO
    {
        public LogDTO() 
        {
            ValidationErrors = new List<string>();
        }

        public string Message { get; set; }
        public string InnerException { get; set; }
        public string StackTrace { get; set; }
        public List<string> ValidationErrors { get; set; }

    }
}
