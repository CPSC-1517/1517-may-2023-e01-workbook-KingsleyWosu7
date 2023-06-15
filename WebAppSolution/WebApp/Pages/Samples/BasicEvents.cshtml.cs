using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Samples
{
    public class BasicEventsModel : PageModel
    {
        //page properties
        public string Feedback;
        /**************
         * OnGet is a method that is called each and everytime this page is created
         * The internet is a stateless environment
         * means any web page that is requested exists in..
         * ********/
        public void OnGet()
        {
            Feedback = "in OnGet";
        }
    }
}
