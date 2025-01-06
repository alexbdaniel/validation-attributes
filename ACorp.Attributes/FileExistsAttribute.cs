using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ACorp.Attributes;

[SuppressMessage("ReSharper", "ConvertIfStatementToReturnStatement")]
public class FileExistsAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext context)
    { 
        string? path = value?.ToString();

        bool exists = File.Exists(path);

        if (exists)
            return ValidationResult.Success;
        
        return new ValidationResult($"File does not exist at \"{path}\"");
    }
}