using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ACorp.Attributes;

[SuppressMessage("ReSharper", "ConvertIfStatementToSwitchStatement")]
public class DirectoryExistsAttribute : ValidationAttribute
{
    /// <summary>
    /// Create the directory (and subdirectories) if it does not exist.
    /// </summary>
    public bool Create { get; set; }
    
    protected override ValidationResult? IsValid(object? value, ValidationContext context)
    { 
        string? path = value?.ToString();
        if (path == null)
            return new ValidationResult($"Path supplied is empty.");
        
        bool exists = Directory.Exists(path);

        if (exists)
            return ValidationResult.Success;
        
        if (!exists && !Create)
            return new ValidationResult($"Directory does not exist at \"{path}\"");
        
        var directory = Directory.CreateDirectory(path);
        
        return ValidationResult.Success;
    }
}