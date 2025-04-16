using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    // [MaxLength(100)]
    public string Username { get; set; }
    
    [Required]
    [StringLength(8, MinimumLength = 4, ErrorMessage = "Username must be between 4 and 8 characters")]
    public string Password { get; set; }

}
