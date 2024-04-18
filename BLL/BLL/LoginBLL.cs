using BLL.Interfaces;
using DAL.DAL;
using DAL.IDAL;
using DTO.AccountInfo;
using DTO.Login;
using DTO.RequestDTO;
using DTO.ResponseDTO;
using Microsoft.IdentityModel.Tokens;
using System.Numerics;
using Utility;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BLL.BLL
{
    public class LoginBLL : ILoginBLL
    {
        public readonly ILoginDAL _loginDAL;
        public readonly IAccountInfoDAL _accountInfoDAL;

        public LoginBLL(ILoginDAL loginDAL, IAccountInfoDAL accountInfoDAL)
        {
            _loginDAL = loginDAL;
            _accountInfoDAL = accountInfoDAL;
        }

        public LoginResponseDTO ValidateLoginCredentials(LoginRequestDTO requestDTO) 
        { 
            LoginResponseDTO responseDTO = _loginDAL.GetUserCredentials(requestDTO);

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

        public void RegisterAccount(AccountRequestDTO requestDTO)
        {
            _accountInfoDAL.RegisterAccount(requestDTO);
        }

        public AccountResponseDTO ValidateRegistration(AccountRequestDTO accountRequestDTO)
        {
            AccountResponseDTO responseDTO = new AccountResponseDTO();

            if (accountRequestDTO.Username.Length < 4 || accountRequestDTO.Username.Length > 20)
            {
                responseDTO.ValidationErrors.Add(Constants.IncorrectUsernameLength);
            }
            else if (string.IsNullOrEmpty(accountRequestDTO.Username))
            {
                responseDTO.ValidationErrors.Add(Constants.UsernameNotValid);
            }

            //check username for non-alphanumeric characters
            //if (/ ^ [a - zA - Z0 - 9] +$/.test(username) == false) {
            //    isValid = false;
            //    errors.push(UsernameCharactersInvalid);
            //}

            if (accountRequestDTO.Password.Length < 8 || accountRequestDTO.Password.Length > 20)
            {
                responseDTO.ValidationErrors.Add(Constants.IncorrectPasswordLength);
            }
            else if (string.IsNullOrEmpty(accountRequestDTO.Password))
            {
                responseDTO.ValidationErrors.Add(Constants.PasswordNotValid);
            }

            //if password does not contain upper and lowercase letters, numbers, and special characters
            //    if (/ ^(?=.*\d)(?=.* [!@#$%^&*])(?=.*[a-z])(?=.*[A-Z]).{8,}$/.test(password) == false) {
            //isValid = false;
            //    errors.
            //    push(PasswordCharactersNotValid);
            //}

            if (string.IsNullOrEmpty(accountRequestDTO.RecoveryQuestion1) || string.IsNullOrEmpty(accountRequestDTO.RecoveryQuestion2) 
                || string.IsNullOrEmpty(accountRequestDTO.RecoveryQuestion3)) 
            {
                responseDTO.ValidationErrors.Add(Constants.RecoveryQuestionEmpty);
            }

            if (string.IsNullOrEmpty(accountRequestDTO.RecoveryAnswer1) || string.IsNullOrEmpty(accountRequestDTO.RecoveryAnswer2)
                || string.IsNullOrEmpty(accountRequestDTO.RecoveryAnswer3))
            {
                responseDTO.ValidationErrors.Add(Constants.RecoveryQuestionEmpty);
            }

            if (string.IsNullOrEmpty(accountRequestDTO.FirstName))
            {
                responseDTO.ValidationErrors.Add(Constants.FirstNameEmpty);
            }

            if (string.IsNullOrEmpty(accountRequestDTO.LastName))
            {
                responseDTO.ValidationErrors.Add(Constants.LastNameEmpty);
            }


            if (string.IsNullOrEmpty(accountRequestDTO.StreetAddress) || string.IsNullOrEmpty(accountRequestDTO.City)
                || accountRequestDTO.ZipCode > 0)
            {
                responseDTO.ValidationErrors.Add(Constants.AddressEmpty);
            }

            if (string.IsNullOrEmpty(accountRequestDTO.Email))
            {
                responseDTO.ValidationErrors.Add(Constants.EmailEmpty);
            }

            ////check if valid email format
            //if (/ ^(([^<> ()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|.(".+"))@((\[[0-9] { 1,3}\.[0-9] { 1,3}\.[0-9] { 1,3}\.[0-9] { 1,3}\])| (([a - zA - Z\-0 - 9] +\.)+ [a - zA - Z]{ 2,}))$/.test(email) == false) {
            //    isValid = false;
            //    errors.push(InvalidEmailFormat);
            //}

            ////check for non numerical characters
            //if (/ ^\d +$/.test(phone.toString()) == false) {
            //    isValid = false;
            //    errors.push(InvalidPhoneFormat);
            //}

            if (accountRequestDTO.Phone.ToString().Length != 10)
            {
                responseDTO.ValidationErrors.Add(Constants.InvalidPhoneLength);
            }

            return responseDTO;
        }
    }
}
