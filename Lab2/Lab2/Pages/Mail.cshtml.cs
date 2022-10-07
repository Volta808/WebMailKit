using Lab2.Model.Courriel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab2.Pages
{
    public class MailModel : PageModel
    {
        [BindProperty]
        public string toMail { get; set; }

        [BindProperty]
        public string subject { get; set; }

        [BindProperty]
        public string message { get; set; }
        public void OnPost()
        {
            if (toMail != null && subject != null && message != null)
            {
                Courriel.toMail = toMail;
                Courriel.message = message;
                Courriel.subject = subject;
                Courriel.envoyer();

            }
        }
    }
}
