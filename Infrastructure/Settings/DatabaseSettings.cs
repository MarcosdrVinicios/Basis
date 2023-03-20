namespace Infrastructure.Settings;

using System.ComponentModel.DataAnnotations;

public class DatabaseSettings
{
    [Required] 
    public string? ConnectionString { get; set; }
}