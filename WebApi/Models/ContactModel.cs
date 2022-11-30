using System.ComponentModel.DataAnnotations;

namespace WebApi.Models;

public class ContactModel
{

    [Required]
    public long Id { get; set; }

    [Required]
    public string FirstName { get; set; }

    public string? LastName { get; set; }

    public string? PhoneNumber { get; set; }
}