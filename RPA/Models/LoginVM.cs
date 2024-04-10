using RPADTO.Login;

namespace RPA.Models
{
    public class LoginVM
    {
        public LoginVM()
        {
            ErrorMessages = new List<string>();
        }

        public LoginVM(LoginResponseDTO responseDTO)
        {
            ErrorMessages = responseDTO.ValidationErrors;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
