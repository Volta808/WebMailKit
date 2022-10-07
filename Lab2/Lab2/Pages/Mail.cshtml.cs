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
        public void OnGet()
        {
        }
    }
}
