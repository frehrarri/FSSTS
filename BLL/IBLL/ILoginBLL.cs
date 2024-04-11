using DTO.AccountInfo;
using DTO.Login;
using DTO.RequestDTO;
using DTO.ResponseDTO;

namespace BLL.Interfaces
{
    public interface ILoginBLL
    {
        public LoginResponseDTO ValidateLoginCredentials(LoginRequestDTO requestDTO);
        public void RegisterAccount(AccountRequestDTO requestDTO);
        public AccountResponseDTO ValidateRegistration(AccountRequestDTO accountRequestDTO);
    }
}
