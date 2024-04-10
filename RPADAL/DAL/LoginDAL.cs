using RPADAL.IDAL;
using RPADTO.AccountInfo;
using RPADTO.Login;
using RPADTO.RequestDTO;
using RPADTO.ResponseDTO;
using RPAEntityFramework.Contexts;
using RPAEntityFramework.EntityModels;
using System.Data.Common;

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
