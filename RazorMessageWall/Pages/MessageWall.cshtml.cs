using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMessageWall.Pages
{
    public class MessageWallModel : PageModel
    {
        [BindProperty] //you are allowed to send information to this property when you post data 
        public string Message { get; set; }

        [BindProperty] // you can post to this.
        public List<string> Messages { get; set; } = new List<string>(); // we don't need binding list in razor pages
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            //write way is to use database, so posting to database then on get reads it
            Messages.Add(Message);
            return Page();
        }
    }
}
