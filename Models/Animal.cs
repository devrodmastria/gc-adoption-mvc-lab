using System;
using System.Collections.Generic;

namespace AdoptionMVClab.Models;

public partial class Animal
{
    public int Id { get; set; }

    public string? Img { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Breed { get; set; }

    public string? Type { get; set; }

    public decimal? Age { get; set; }
}
