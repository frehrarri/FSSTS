using RPADTO.Login;
using RPADTO.RequestDTO;

namespace RPABLL.Interfaces
{
    public interface ILoginBLL
    {
        public LoginResponseDTO ValidateLoginCredentials(LoginRequestDTO requestDTO);
    }
}
