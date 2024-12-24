using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Login_SignUp_Form.Models;

public partial class User
{
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = null!;

    [Required]
    public string LastName { get; set; } = null!;

    [Required]
    public string Gender { get; set; } = null!;

    [Required]
    public int? Age { get; set; }

    [Required]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Required]
    public string Password { get; set; } = null!;
}
