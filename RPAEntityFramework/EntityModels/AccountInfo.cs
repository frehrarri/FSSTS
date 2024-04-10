using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace RPAEntityFramework.EntityModels
{
    [Table("AccountInfo")]
    public class AccountInfo : MetaData
    {
        [Key]
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
    }
}
