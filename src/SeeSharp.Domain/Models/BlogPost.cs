﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SeeSharp.Domain.Models;

public class BlogPost : Entity
{
    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Category { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;
}