using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTest.Pages
{
    public class MyTabModel : PageModel
    {
        private readonly ILogger<MyTabModel> _logger;

        public MyTabModel(ILogger<MyTabModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
