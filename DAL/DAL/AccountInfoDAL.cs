using DAL.IDAL;
using DTO;
using DTO.AccountInfo;
using DTO.ResponseDTO;
using EntityFramework;
using EntityFramework.Contexts;
using EntityFramework.EntityModels;

namespace DAL.DAL
{
    public class AccountInfoDAL : IAccountInfoDAL
    {
        public AccountResponseDTO RegisterAccount(AccountRequestDTO requestDTO)
        {
            AccountResponseDTO responseDTO = new AccountResponseDTO();

            using (var context = new EntityContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        AccountInfo accountInfo = new AccountInfo();
                        accountInfo.Username = requestDTO.Username;
                        accountInfo.Password = requestDTO.Password;
                        accountInfo.IsActive = true;
                        accountInfo.RecoveryQuestion1 = requestDTO.RecoveryQuestion1;
                        accountInfo.RecoveryQuestion2 = requestDTO.RecoveryQuestion2;
                        accountInfo.RecoveryQuestion3 = requestDTO.RecoveryQuestion3;
                        accountInfo.RecoveryAnswer1 = requestDTO.RecoveryAnswer1;
                        accountInfo.RecoveryAnswer2 = requestDTO.RecoveryAnswer2;
                        accountInfo.RecoveryAnswer3 = requestDTO.RecoveryAnswer3;
                        accountInfo.CreatedDate = DateTime.Now;
                        accountInfo.ModifiedDate = DateTime.MinValue;
                        accountInfo.ModifiedBy = null;

                        context.AccountInfo.Add(accountInfo);

                        transaction.Commit();

                        
                    }
                    catch (Exception e)
                    {

                    }
                }
            }

            return responseDTO;
        }

    }
}
