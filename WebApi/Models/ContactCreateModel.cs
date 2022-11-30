using System.ComponentModel.DataAnnotations;

namespace WebApi.Models;

public class ContactCreateModel
{
    [Required]
    public string FirstName { get; set; }

    public string? LastName { get; set; }

    public string? PhoneNumber { get; set; }
}