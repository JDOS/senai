using System.ComponentModel.DataAnnotations;

namespace Chapter.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe e-mail do usuário")]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário")]
        public string senha { get; set; }
    }
}
