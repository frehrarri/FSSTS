using DAL.IDAL;
using DTO.AccountInfo;
using DTO.Login;
using DTO.RequestDTO;
using DTO.ResponseDTO;
using EntityFramework.Contexts;
using EntityFramework.EntityModels;
using System.Data.Common;

namespace DAL.DAL
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
