namespace DTO.Login
{
    public class LoginResponseDTO : BaseDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Authorized { get; set; }
    }
}
