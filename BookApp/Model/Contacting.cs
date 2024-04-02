using System.ComponentModel.DataAnnotations;

namespace BookApp.Model;

public class Contacting
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
}