using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AbetMvc.Models;

public enum Major
{
    CS, CpE, EE
}

[Index(nameof(Number), nameof(Major), IsUnique=true)]
public class Outcome
{
    public int Id { get; set; }

    public int Number { get; set; }

    public string? Description { get; set; }

    public Major Major { get; set; }
}