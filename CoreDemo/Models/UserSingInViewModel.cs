using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSingInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını girin")]
        public string username { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi girin")]
        public string password { get; set; }
    }
}
