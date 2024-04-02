using BookApp.Model;
using MudBlazor;

namespace BookApp.Pages;

public partial class Contact
{
    private readonly Contacting _contacting = new();
    private void OnSubmit()
    {
        Snackbar.Add("Email wurde gesendet!", Severity.Success);
    }
}