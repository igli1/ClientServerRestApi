using System.ComponentModel.DataAnnotations;

namespace Server.Models;

public class LogDto
{
    [Required(ErrorMessage = "Log message is required.")]
    public string Log { get; set; }
}