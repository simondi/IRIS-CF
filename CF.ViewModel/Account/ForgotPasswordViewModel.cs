using System.ComponentModel.DataAnnotations;

namespace IRIS.ViewModel.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }
    }
}
