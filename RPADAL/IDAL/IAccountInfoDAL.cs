using RPADTO.AccountInfo;
using RPADTO.Login;
using RPADTO.ResponseDTO;

namespace RPADAL.IDAL
{
    public interface IAccountInfoDAL
    {
        public AccountResponseDTO RegisterAccount(AccountRequestDTO requestDTO);
    }
}
