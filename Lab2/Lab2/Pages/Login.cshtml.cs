using Lab2.Model.Courriel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Display(Name = "Entrez votre courriel")]
        public string email { get; set; }

        [BindProperty]
        [Display(Name = "Entrez le mot de passe")]
        public string password { get; set; }

        public void OnPost()
        {
            if(email != null && password != null){
                Courriel.password = password;
                Courriel.fromMail = email;
                Response.Redirect("Mail");
            }
        }
    }
}
