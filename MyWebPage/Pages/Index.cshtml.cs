using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace YourProjectNamespace.Pages
{
    public class IndexModel : PageModel
    {
        public string WelcomeMessage { get; set; }
        public string CurrentTime { get; set; }

        public void OnGet()
        {
            WelcomeMessage = "Hello! This is your Capstone Project deployed on Azure.";
            CurrentTime = DateTime.Now.ToString("f"); // Full date/time pattern (long time)
        }
    }
}
