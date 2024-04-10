namespace DTO.ResponseDTO
{
    public class AccountResponseDTO
    {
        public int AccountInfoID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RecoveryQuestion1 { get; set; }
        public string RecoveryQuestion2 { get; set; }
        public string RecoveryQuestion3 { get; set; }
        public string RecoveryAnswer1 { get; set; }
        public string RecoveryAnswer2 { get; set; }
        public string RecoveryAnswer3 { get; set; }
        public bool IsActive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
    }
}
