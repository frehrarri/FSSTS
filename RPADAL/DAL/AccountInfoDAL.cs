using RPADAL.IDAL;
using RPADTO;
using RPADTO.AccountInfo;
using RPADTO.ResponseDTO;
using RPAEntityFramework;
using RPAEntityFramework.EntityModels;

namespace RPADAL.DAL
{
    public class AccountInfoDAL : IAccountInfoDAL
    {
        LogDTO _logDTO;

        public AccountInfoDAL(LogDTO logDTO)
        {
            _logDTO = logDTO;   
        }

        public void RegisterAccount(AccountRequestDTO requestDTO)
        {
            using (var context = new AccountInfoContext())
            {
                try
                {
                    AccountInfo dataForSave = new AccountInfo();

                    dataForSave.Username = requestDTO.Username;
                    dataForSave.Password = requestDTO.Password;
                    dataForSave.IsActive = true;
                    dataForSave.RecoveryQuestion1 = requestDTO.RecoveryQuestion1;
                    dataForSave.RecoveryQuestion2 = requestDTO.RecoveryQuestion2;
                    dataForSave.RecoveryQuestion3 = requestDTO.RecoveryQuestion3;
                    dataForSave.RecoveryAnswer1 = requestDTO.RecoveryAnswer1;
                    dataForSave.RecoveryAnswer2 = requestDTO.RecoveryAnswer2;
                    dataForSave.RecoveryAnswer3 = requestDTO.RecoveryAnswer3;
                    dataForSave.RegistrationDate = DateTime.Now;

                    context.AccountInfo.Add(dataForSave);

                }
                catch (Exception e)
                {
                    _logDTO.InnerException = e.InnerException.ToString();
                    _logDTO.StackTrace = e.StackTrace.ToString();
                    _logDTO.Message = e.Message;
                    //add functionality to log this message
                    throw;
                }
                

            }
           
        }
    }
}
