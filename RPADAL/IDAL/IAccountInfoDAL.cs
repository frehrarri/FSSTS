using RPADTO.AccountInfo;
using RPADTO.ResponseDTO;

namespace RPADAL.IDAL
{
    public interface IAccountInfoDAL
    {
        public void RegisterUser(AccountRequestDTO requestDTO);
    }
}
