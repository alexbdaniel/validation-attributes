# Getting started

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

The optional argument "Create", will create the directory if it does not exist; <br>
it will create any necessary subdirectories too.
