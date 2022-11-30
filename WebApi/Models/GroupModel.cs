using System.ComponentModel.DataAnnotations;

namespace WebApi.Models;

public class GroupModel
{
    [Required]
    public long Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int MemberCount { get; set; }
}