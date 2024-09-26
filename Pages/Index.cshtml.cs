using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp_sam_lab13.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    <h1>Portfolio Gallery</h1>
     <P>This is a simple .NET web project.</P>
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
