namespace RPADTO
{
    public interface ILogDTO
    {
        public string Message { get; set; }
        public string InnerException { get; set; }
        public string StackTrace { get; set; }
        public List<string> ValidationErrors { get; set; }
    }
}
