# Getting started
Note: Intended to be used with the Options.DataAnnotations library or anything else which parses validation attributes.

## Examples

### Files
```csharp
[FileExists]
public required string PhotosFilePath { get; init; }
```

### Directories
```csharp
[DirectoryExists(Create = true)]
public required string ConfigurationDirectoryName { get; init; }
```

The optional argument "Create", will create the directory if it does not exist; \
it will create any necessary subdirectories too.

### Configuration
```csharp
services.AddOptions<DatabaseOptions>().Bind(configuration.GetSection(DatabaseOptions.Key))
            .ValidateDataAnnotations()
            .ValidateOnStart();
```
