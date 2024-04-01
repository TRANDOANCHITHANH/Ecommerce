using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ViewModels
{
    public class LoginVM
    {
        [Display(Name ="Tên đăng nhập")]
        [Required(ErrorMessage ="Tên đăng nhập không được để trống")]
        [MaxLength(20,ErrorMessage ="Tối đa 20 kí tự")]
        public string UserName { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
