using System.ComponentModel.DataAnnotations;

namespace Auth.System.Data{
    public class LoginRequest{
        [Required(ErrorMessage ="Enter correct email address")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]  
        // [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Email is not valid")]             
        public string ? Email{get;set;}
        public string ? Password{get;set;}

    }
}