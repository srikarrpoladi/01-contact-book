using System.ComponentModel.DataAnnotations;

namespace WebApi.Models;

public class GroupCreateModel
{
    [Required]
    public string Name { get; set; }
}