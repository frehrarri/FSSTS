using DTO.AccountInfo;
using DTO.Login;
using DTO.ResponseDTO;

namespace DAL.IDAL
{
    public interface IAccountInfoDAL
    {
        public AccountResponseDTO RegisterAccount(AccountRequestDTO requestDTO);
    }
}
