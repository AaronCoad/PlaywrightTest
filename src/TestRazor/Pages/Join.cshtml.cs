using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestRazor.Pages;
public class JoinModel : PageModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Email address must be provided.")]
    public string Email { get; set; } = default!;
    [Required(AllowEmptyStrings = false, ErrorMessage = "Must enter a name")]
    public string Name { get; set; } = default!;
    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (this.ModelState.IsValid == false)
            return Page();

        return RedirectToPage("./Join");
    }
}
