using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required,EmailAddressAttribute]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
