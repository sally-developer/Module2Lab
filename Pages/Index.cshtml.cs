using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module2Challenge.Pages
{
    public class IndexModel : PageModel
    {
        // Property to store the number of miles driven, bound to the form input
        [BindProperty]
        public double MilesDriven { get; set; }

        // Property to store the number of gallons of fuel used, bound to the form input
        [BindProperty]
        public double GallonsUsed { get; set; }

        // Property to hold the calculated MPG result, displayed after calculation
        public double? Mpg { get; set; }

        // Runs on initial page load (GET request) — nothing needed here yet
        public void OnGet()
        {
        }

        // Runs when the form is submitted (POST request)
        public void OnPost()
        {
            // Guard against dividing by zero or invalid input
            if (GallonsUsed > 0)
            {
                // Calculate miles per gallon using the given formula
                double mpg = MilesDriven / GallonsUsed;
                Mpg = mpg;
            }
            else
            {
                // No valid gallons value provided, so no result to show
                Mpg = null;
            }
        }
    }
}