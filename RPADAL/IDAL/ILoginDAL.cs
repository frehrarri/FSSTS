using RPADTO.Login;
using RPADTO.RequestDTO;

namespace RPADAL.IDAL
{
    public interface ILoginDAL
    {
        public LoginResponseDTO GetUserCredentials(LoginRequestDTO requestDTO);
    }
}
