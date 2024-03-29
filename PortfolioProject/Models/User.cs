﻿using System.ComponentModel.DataAnnotations;

namespace PortfolioProject.Models;

public class User
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Subject { get; set; }
    [Required]
    public string Message { get; set; }
}