using DTO.Login;
using DTO.RequestDTO;

namespace DAL.IDAL
{
    public interface ILoginDAL
    {
        public LoginResponseDTO GetUserCredentials(LoginRequestDTO requestDTO);
    }
}
