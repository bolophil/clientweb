using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cientweb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public string Username { get; set; } = "";

        [BindProperty]
        public string Password { get; set; } = "";

        public string Msg = "";
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            if(Username.Equals("guest") && Password.Equals("guest"))
            {
                return RedirectToPage("/Clients/Index");
            }
            else
            {
                Msg = "Invalid Username or Password";
                return Page();
            }
        }
    }
}