using RPADAL.IDAL;
using RPADTO.Login;
using RPADTO.RequestDTO;

namespace RPADAL.DAL
{
    public class LoginDAL : ILoginDAL
    {
        public LoginResponseDTO GetUserCredentials(LoginRequestDTO requestDTO)
        {
            LoginResponseDTO responseDTO = new LoginResponseDTO();
            return responseDTO;
        }

    }
}
