using DTO.AccountInfo;
using DTO.Login;
using DTO.RequestDTO;

namespace BLL.Interfaces
{
    public interface ILoginBLL
    {
        public LoginResponseDTO ValidateLoginCredentials(LoginRequestDTO requestDTO);
        public void RegisterAccount(AccountRequestDTO requestDTO);
    }
}
