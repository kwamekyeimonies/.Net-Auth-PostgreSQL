using System.ComponentModel.DataAnnotations;

namespace Auth.System.Data{
    public class RegisterRequest{
        [Required]
        public string ? Firstname{get;set;}
        [Required]
        public string ? Lastname{get;set;}
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string ? Email{get;set;}
        [Required]
        public string ? Password{get;set;}
    }
}