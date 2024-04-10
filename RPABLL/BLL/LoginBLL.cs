using RPABLL.Interfaces;
using RPADAL.IDAL;
using RPADTO.Login;
using RPADTO.RequestDTO;
using RPAUtility;

namespace RPABLL.BLL
{
    public class LoginBLL : ILoginBLL
    {
        public readonly ILoginDAL _LoginDAL;

        public LoginBLL(ILoginDAL LoginDAL)
        {
            _LoginDAL = LoginDAL;
        }

        public LoginResponseDTO ValidateLoginCredentials(LoginRequestDTO requestDTO) 
        { 
            LoginResponseDTO responseDTO = _LoginDAL.GetUserCredentials(requestDTO);

            responseDTO.Authorized = true;
            if (requestDTO.UserName != responseDTO.Username)
            {
                responseDTO.Authorized = false;
                responseDTO.ValidationErrors.Add(Constants.IncorrectUsername);
            }

            if (requestDTO.Password != responseDTO.Password)
            {
                responseDTO.Authorized = false;
                responseDTO.ValidationErrors.Add(Constants.IncorrectPassword);
            }

            return responseDTO;
        }
    }
}
