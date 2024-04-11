namespace Utility
{
    public static class Constants
    {
        #region Configs

        public static string SiteURL = "https://localhost:7241/";

        #endregion

        #region Validation

        //Login
        public static string IncorrectPassword = "Incorrect Password";
        public static string IncorrectUsername = "Incorrect Username";

        //Register
        public static string UsernameNotValid = "Invalid Username";
        public static string UsernameExists = "{0} already exists. Please select another name";
        public static string IncorrectUsernameLength = "Username must be between 4 and 20 characters";
        public static string UsernameCharactersInvalid = "Username can not have special characters";
        public static string PasswordNotValid = "Incorrect password";
        public static string IncorrectPasswordLength = "Password must be between 8 and 20 characters";
        public static string PasswordCharactersNotValid = "Password must contain letters, numbers, and special characters";
        public static string RecoveryQuestionEmpty = "Please enter a question you will remember the answer to";
        public static string RecoveryAnswerEmpty = "Please enter an answer for the recovery question";
        public static string FirstNameEmpty = "Please enter your first name";
        public static string LastNameEmpty = "Please enter your last name";
        public static string AddressEmpty = "Please enter your address";
        public static string EmailEmpty = "Please enter your email";
        public static string InvalidEmailFormat = "Invalid email format";
        public static string PhoneEmpty = "Please enter your phone number";
        public static string InvalidPhoneFormat = "Phone numbers can only contain numbers";
        public static string InvalidPhoneLength = "Phone numbers must contain 10 digits";

        #endregion

    }
}
