namespace RPAUtility
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
        public static string PasswordNotValid = "Invalid password. Password must have 8 characters";

        #endregion

    }
}
